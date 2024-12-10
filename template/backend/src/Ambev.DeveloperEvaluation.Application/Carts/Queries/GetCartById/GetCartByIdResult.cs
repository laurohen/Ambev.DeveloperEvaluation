using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Queries.GetCartById
{
    /// <summary>
    /// Result of the GetCartByIdQuery execution.
    /// </summary>
    public class GetCartByIdResult
    {
        /// <summary>
        /// The unique identifier of the cart.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The ID of the user who owns the cart.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// The date and time when the cart was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the cart was last updated, if applicable.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The list of items in the cart.
        /// </summary>
        public List<CartItemResult> Products { get; set; } = new();
    }

    /// <summary>
    /// Represents an individual item in the cart.
    /// </summary>
    public class CartItemResult
    {
        /// <summary>
        /// The unique identifier of the product.
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// The quantity of the product in the cart.
        /// </summary>
        public int Quantity { get; set; }
    }
}
