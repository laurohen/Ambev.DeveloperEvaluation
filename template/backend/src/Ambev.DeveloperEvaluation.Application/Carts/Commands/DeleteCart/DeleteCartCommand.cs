using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.DeleteCart
{
    /// <summary>
    /// Command for deleting a cart.
    /// </summary>
    public record DeleteCartCommand : IRequest<bool>
    {
        /// <summary>
        /// The unique identifier of the cart to delete.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Initializes a new instance of DeleteCartCommand.
        /// </summary>
        /// <param name="id">The ID of the cart to delete.</param>
        public DeleteCartCommand(Guid id)
        {
            Id = id;
        }
    }
}
