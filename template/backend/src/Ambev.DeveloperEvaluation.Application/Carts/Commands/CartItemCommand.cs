using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands
{
    /// <summary>
    /// Command for representing a cart item in the application layer.
    /// </summary>
    public class CartItemCommand
    {
        /// <summary>
        /// The ID of the product.
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// The quantity of the product in the cart.
        /// </summary>
        public int Quantity { get; set; }
    }
}
