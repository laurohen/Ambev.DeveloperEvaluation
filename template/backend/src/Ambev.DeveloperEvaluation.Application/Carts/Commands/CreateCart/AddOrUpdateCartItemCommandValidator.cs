using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.CreateCart
{
    public class AddOrUpdateCartItemCommandValidator : AbstractValidator<AddOrUpdateCartItemCommand>
    {
        public AddOrUpdateCartItemCommandValidator()
        {
            RuleFor(cart => cart.ProductId).NotEmpty().WithMessage("ProductId cannot be empty.");
            RuleFor(cart => cart.UserId).NotEmpty().WithMessage("UserId cannot be empty.");
            RuleFor(cart => cart.Quantity).NotEmpty().NotEqual(0).WithMessage("Quantity cannot be empty.");
        }
    }
}
