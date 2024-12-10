using Ambev.DeveloperEvaluation.Domain.Models.CartAggregate.Entities;
using Ambev.DeveloperEvaluation.Domain.Models.CartAggregate;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.UpdateCart
{
    /// <summary>
    /// Handles the execution of the UpdateCartCommand.
    /// </summary>
    public class UpdateCartCommandHandler : IRequestHandler<UpdateCartCommand, UpdateCartResult?>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the UpdateCartCommandHandler class.
        /// </summary>
        /// <param name="cartRepository">The cart repository.</param>
        /// <param name="mapper">The mapper for DTO and entity transformations.</param>
        public UpdateCartCommandHandler(ICartRepository cartRepository, IMapper mapper)
        {
            _cartRepository = cartRepository ?? throw new ArgumentNullException(nameof(cartRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Handles the UpdateCartCommand.
        /// </summary>
        /// <param name="request">The command containing updated cart details.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The result of the update operation.</returns>
        public async Task<UpdateCartResult?> Handle(UpdateCartCommand request, CancellationToken cancellationToken)
        {
            // Retrieve the cart from the repository
            var cart = await _cartRepository.GetByIdAsync(request.Id, cancellationToken);
            if (cart == null)
            {
                return null; // Cart not found
            }

            // Update the cart's items
            var updatedItems = request.Products.Select(p => new CartItem(cart.Id, p.ProductId, p.Quantity)).ToArray();
            cart.UpdateItems(updatedItems);

            // Update the timestamp
            cart.UpdateDate();

            // Save the changes to the repository
            var updatedCart = await _cartRepository.UpdateAsync(cart, cancellationToken);

            // Map the updated cart to the result object
            return _mapper.Map<UpdateCartResult>(updatedCart);
        }
    }
}
