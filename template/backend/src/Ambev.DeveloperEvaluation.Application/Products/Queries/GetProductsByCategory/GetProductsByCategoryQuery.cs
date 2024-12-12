using Ambev.DeveloperEvaluation.Application.Products.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.Queries.GetProductsByCategory
{
    /// <summary>
    /// Query to retrieve products by category with pagination and sorting.
    /// </summary>
    public class GetProductsByCategoryQuery : IRequest<PaginatedResult<ProductDto>>
    {
        public string Category { get; set; } = string.Empty;
        public int Page { get; set; } = 1;
        public int Size { get; set; } = 10;
        public string? Order { get; set; }
    }
}
