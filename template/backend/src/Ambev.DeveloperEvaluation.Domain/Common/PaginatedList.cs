using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Common
{
    /// <summary>
    /// Represents a paginated list of items.
    /// </summary>
    public class PaginatedList<T>
    {
        public List<T> Items { get; private set; } = new();
        public int TotalItems { get; private set; }
        public int CurrentPage { get; private set; }
        public int PageSize { get; private set; }

        private PaginatedList(List<T> items, int totalItems, int currentPage, int pageSize)
        {
            Items = items;
            TotalItems = totalItems;
            CurrentPage = currentPage;
            PageSize = pageSize;
        }

        /// <summary>
        /// Creates a paginated list.
        /// </summary>
        public static PaginatedList<T> Create(List<T> items, int totalItems, int currentPage, int pageSize)
        {
            return new PaginatedList<T>(items, totalItems, currentPage, pageSize);
        }
    }

}
