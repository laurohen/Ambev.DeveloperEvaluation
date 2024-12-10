using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Queries.ListCarts
{
    /// <summary>
    /// Query to list carts with pagination and ordering.
    /// </summary>
    public class ListCartsQuery : IRequest<ListCartsResult>
    {
        /// <summary>
        /// The current page number.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// The number of items per page.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// The ordering criteria (e.g., "createdAt desc").
        /// </summary>
        public string? OrderBy { get; set; }

        /// <summary>
        /// Initializes a new instance of the ListCartsQuery class.
        /// </summary>
        /// <param name="page">The page number (default: 1).</param>
        /// <param name="pageSize">The size of the page (default: 10).</param>
        /// <param name="orderBy">The ordering criteria.</param>
        public ListCartsQuery(int page = 1, int pageSize = 10, string? orderBy = null)
        {
            Page = page > 0 ? page : 1;
            PageSize = pageSize > 0 ? pageSize : 10;
            OrderBy = orderBy;
        }
    }
}
