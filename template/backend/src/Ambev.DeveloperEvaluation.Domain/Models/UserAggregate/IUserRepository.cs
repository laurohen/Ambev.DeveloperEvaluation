﻿using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Models.UserAggregate
{
    /// <summary>
    ///     Repository interface for User entity operations
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        ///     Creates a new user in the repository
        /// </summary>
        /// <param name="user">The user to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created user</returns>
        Task<User> CreateAsync(User user, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Update a user   
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<User> UpdateAsync(User user, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Retrieves a user by their unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the user</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The user if found, null otherwise</returns>
        Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Retrieves a user by their email address
        /// </summary>
        /// <param name="email">The email address to search for</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The user if found, null otherwise</returns>
        Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Deletes a user from the repository
        /// </summary>
        /// <param name="id">The unique identifier of the user to delete</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>True if the user was deleted, false if not found</returns>
        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Retrieves all users from the repository with pagination and sorting
        /// </summary>
        /// <param name="page">The page number (starting from 1)</param>
        /// <param name="size">The number of users per page</param>
        /// <param name="order">The sorting order (e.g., "name ASC", "email DESC")</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>A list of users based on the specified page, size, and sorting order</returns>
        Task<IEnumerable<User>> GetAllAsync(int page, int size, string order, CancellationToken cancellationToken = default);

        /// <summary>
        ///     Counts the total number of users in the repository
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The total number of users</returns>
        Task<int> CountAsync(CancellationToken cancellationToken = default);
    }
}
