using Ambev.DeveloperEvaluation.Domain.Models.CartAggregate;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.DeleteCart
{
    public class DeleteCartItemCommandHandler(ICartRepository cartRepository) : IRequestHandler<DeleteCartItemCommand, bool>
    {
        public async Task<bool> Handle(DeleteCartItemCommand command, CancellationToken cancellationToken)
        {
            var validator = new DeleteCartItemValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var cart = await cartRepository.GetByUserIdAsync(command.UserId, cancellationToken)
                       ?? throw new KeyNotFoundException($"Cart for UserId {command.UserId} not found.");

            cart.RemoveProduct(command.ProductId);

            if (!cart.Products.Any())
                await cartRepository.DeleteAsync(cart.Id, cancellationToken);
            else
                await cartRepository.UpdateAsync(cart, cancellationToken);

            return true;
        }
    }
}
