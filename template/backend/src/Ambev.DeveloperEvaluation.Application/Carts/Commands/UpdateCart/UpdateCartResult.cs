using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.UpdateCart
{
    /// <summary>
    /// Result of the UpdateCartCommand execution.
    /// </summary>
    public class UpdateCartResult
    {
        /// <summary>
        /// The unique identifier of the updated cart.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The date and time when the cart was last updated.
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The list of items in the updated cart.
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
