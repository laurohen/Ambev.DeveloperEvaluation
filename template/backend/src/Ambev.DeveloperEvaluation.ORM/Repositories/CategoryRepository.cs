using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate.Entities;
using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    /// <summary>
    /// Implementation of ICategoryRepository using Entity Framework Core.
    /// </summary>
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DefaultContext _context;

        /// <summary>
        /// Initializes a new instance of CategoryRepository.
        /// </summary>
        /// <param name="context">The database context.</param>
        public CategoryRepository(DefaultContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Creates a new category in the database.
        /// </summary>
        /// <param name="category">The category to create.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The created category.</returns>
        public async Task<Category> CreateAsync(Category category, CancellationToken cancellationToken = default)
        {
            await _context.Categories.AddAsync(category, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return category;
        }

        /// <summary>
        /// Retrieves a category by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the category.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The category if found, null otherwise.</returns>
        public async Task<Category?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _context.Categories
                .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
        }

        /// <summary>
        /// Updates an existing category in the database.
        /// </summary>
        /// <param name="category">The category to update.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The updated category.</returns>
        public async Task<Category> UpdateAsync(Category category, CancellationToken cancellationToken = default)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync(cancellationToken);
            return category;
        }

        /// <summary>
        /// Deletes a category from the database.
        /// </summary>
        /// <param name="id">The unique identifier of the category to delete.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>True if the category was deleted, false otherwise.</returns>
        public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var category = await GetByIdAsync(id, cancellationToken);
            if (category == null)
                return false;

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        /// <summary>
        /// Retrieves all categories from the database.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>A list of all categories.</returns>
        public async Task<List<Category>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Categories
                .OrderBy(c => c.Name)
                .ToListAsync(cancellationToken);
        }

        public async Task<Category?> GetByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Name == name, cancellationToken);
        }
        public async Task<List<Category>> GetCategoriesAsync(int page, int size, CancellationToken cancellationToken = default)
        {
            return await _context.Categories
                .OrderBy(c => c.Name)
                .Skip((page - 1) * size)
                .Take(size)
                .ToListAsync(cancellationToken);
        }

        public async Task<int> GetTotalCountAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Categories.CountAsync(cancellationToken);
        }
    }


}
