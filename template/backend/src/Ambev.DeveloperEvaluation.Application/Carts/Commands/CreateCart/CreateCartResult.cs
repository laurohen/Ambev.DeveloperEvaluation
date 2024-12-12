using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.CreateCart
{
    /// <summary>
    /// Result of the CreateCartCommand execution.
    /// </summary>
    public class CreateCartResult
    {
        /// <summary>
        /// The unique identifier of the created cart.
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
        /// The list of items in the created cart.
        /// </summary>
        public List<CartItemCommand> Products { get; set; } = new();
    }
}
