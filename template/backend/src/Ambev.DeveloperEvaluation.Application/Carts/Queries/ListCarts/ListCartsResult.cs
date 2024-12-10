using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Queries.ListCarts
{
    /// <summary>
    /// Response model for listing carts with pagination support.
    /// </summary>
    public class ListCartsResult
    {
        public List<CartDto> Data { get; set; } = new();
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }

    /// <summary>
    /// Represents a simplified cart object in the list response.
    /// </summary>
    public class CartDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public List<CartItemListDto> Products { get; set; } = new();
    }

    /// <summary>
    /// Represents a simplified product item within a cart.
    /// </summary>
    public class CartItemListDto
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
