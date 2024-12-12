using Ambev.DeveloperEvaluation.Domain.Models.CartAggregate;
using Ambev.DeveloperEvaluation.Domain.Models.CartAggregate.Entities;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.CreateCart
{
    public class CreateOrUpdateCartCommandHandler(
    ICartRepository cartRepository,
    IMapper mapper)
    : IRequestHandler<AddOrUpdateCartItemCommand, CreateOrUpdateCartResult>
    {
        public async Task<CreateOrUpdateCartResult> Handle(AddOrUpdateCartItemCommand command, CancellationToken cancellationToken)
        {
            var validator = new AddOrUpdateCartItemCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var cart = await cartRepository.GetByUserIdAsync(command.UserId, cancellationToken) ?? new Cart(command.UserId);

            cart.AddProduct(command.ProductId, command.Quantity);

            cart.UpdateDate();

            if (cart.Id == Guid.Empty)
                await cartRepository.CreateAsync(cart, cancellationToken);
            else
                await cartRepository.UpdateAsync(cart, cancellationToken);

            return mapper.Map<CreateOrUpdateCartResult>(cart);
        }
    }
}
