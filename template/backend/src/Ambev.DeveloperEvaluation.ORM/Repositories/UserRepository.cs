using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate;
using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

/// <summary>
///     Implementation of IUserRepository using Entity Framework Core
/// </summary>
public class UserRepository : IUserRepository
{
    private readonly DefaultContext _context;

    /// <summary>
    ///     Initializes a new instance of UserRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public UserRepository(DefaultContext context)
    {
        _context = context;
    }

    /// <summary>
    ///     Creates a new user in the database
    /// </summary>
    /// <param name="user">The user to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created user</returns>
    public async Task<User> CreateAsync(User user, CancellationToken cancellationToken = default)
    {
        await _context.Users.AddAsync(user, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return user;
    }

    public async Task<User> UpdateAsync(User user, CancellationToken cancellationToken = default)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync(cancellationToken);
        return user;
    }

    /// <summary>
    ///     Retrieves a user by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier of the user</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The user if found, null otherwise</returns>
    public async Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Users.FirstOrDefaultAsync(o => o.Id == id, cancellationToken);
    }

    /// <summary>
    ///     Retrieves a user by their email address
    /// </summary>
    /// <param name="email">The email address to search for</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The user if found, null otherwise</returns>
    public async Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
    {
        return await _context.Users
            .FirstOrDefaultAsync(u => u.Email == email, cancellationToken);
    }

    /// <summary>
    ///     Deletes a user from the database
    /// </summary>
    /// <param name="id">The unique identifier of the user to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the user was deleted, false if not found</returns>
    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var user = await GetByIdAsync(id, cancellationToken);
        if (user == null)
            return false;

        _context.Users.Remove(user);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }

    /// <summary>
    ///     Retrieves all users from the repository with pagination and sorting
    /// </summary>
    /// <param name="page">The page number (starting from 1)</param>
    /// <param name="size">The number of users per page</param>
    /// <param name="order">The sorting order (e.g., "name ASC", "email DESC")</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A list of users based on the specified page, size, and sorting order</returns>
    public async Task<IEnumerable<User>> GetAllAsync(int page, int size, string order, CancellationToken cancellationToken = default)
    {
        IQueryable<User> query = _context.Users;

        // Aplica a ordenação dinâmica
        if (!string.IsNullOrWhiteSpace(order))
        {
            query = ApplyOrdering(query, order);
        }

        // Aplica a paginação
        query = query.Skip((page - 1) * size).Take(size);

        return await query.ToListAsync(cancellationToken);
    }

    /// <summary>
    ///     Counts the total number of users in the repository
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The total number of users</returns>
    public async Task<int> CountAsync(CancellationToken cancellationToken = default)
    {
        return await _context.Users.CountAsync(cancellationToken);
    }

    private IQueryable<User> ApplyOrdering(IQueryable<User> query, string order)
    {
        var orderParts = order.Split(' ');

        if (orderParts.Length != 2)
            throw new ArgumentException("A ordem deve estar no formato 'Campo Direção'");

        var propertyName = orderParts[0];
        var direction = orderParts[1].ToUpper() == "DESC" ? "Descending" : "Ascending";

        // Cria a expressão dinâmica para ordenação
        var parameter = Expression.Parameter(typeof(User), "u");
        var property = Expression.Property(parameter, propertyName);
        var lambda = Expression.Lambda(property, parameter);

        // Determina o método de ordenação com base na direção
        var methodName = direction == "Descending" ? "OrderByDescending" : "OrderBy";
        var orderByMethod = typeof(Queryable).GetMethods()
            .FirstOrDefault(m => m.Name == methodName && m.GetParameters().Length == 2)
            .MakeGenericMethod(typeof(User), property.Type);

        return (IQueryable<User>)orderByMethod.Invoke(null, new object[] { query, lambda });
    }

}
