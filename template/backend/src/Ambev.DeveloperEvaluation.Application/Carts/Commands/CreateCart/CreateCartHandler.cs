using Ambev.DeveloperEvaluation.Domain.Models.CartAggregate.Entities;
using Ambev.DeveloperEvaluation.Domain.Models.CartAggregate;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.CreateCart
{
    /// <summary>
    /// Handler for processing CreateCartCommand requests.
    /// </summary>
    public class CreateCartHandler : IRequestHandler<CreateCartCommand, CreateCartResult>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of CreateCartHandler.
        /// </summary>
        /// <param name="cartRepository">The cart repository.</param>
        /// <param name="mapper">The AutoMapper instance.</param>
        public CreateCartHandler(ICartRepository cartRepository, IMapper mapper)
        {
            _cartRepository = cartRepository ?? throw new ArgumentNullException(nameof(cartRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Handles the CreateCartCommand request.
        /// </summary>
        /// <param name="command">The CreateCart command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The created cart details.</returns>
        public async Task<CreateCartResult> Handle(CreateCartCommand command, CancellationToken cancellationToken)
        {
            // Validate the command
            var validator = new CreateCartCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);
            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            // Map the command to the Cart entity
            var cart = _mapper.Map<Cart>(command);

            // Save the cart to the repository
            var createdCart = await _cartRepository.CreateAsync(cart, cancellationToken);

            // Map the created cart to the result
            var result = _mapper.Map<CreateCartResult>(createdCart);
            return result;
        }
    }
}
