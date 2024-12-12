using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.CreateCart
{
    /// <summary>
    /// Validator for CreateCartCommand.
    /// </summary>
    public class CreateCartCommandValidator : AbstractValidator<CreateCartCommand>
    {
        public CreateCartCommandValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("UserId is required.");
            RuleFor(x => x.Products).NotEmpty().WithMessage("Products are required.");
            RuleForEach(x => x.Products).SetValidator(new CartItemDtoValidator());
        }
    }

    /// <summary>
    /// Validator for CartItemDto.
    /// </summary>
    public class CartItemDtoValidator : AbstractValidator<CreateCartItemDto>
    {
        public CartItemDtoValidator()
        {
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("ProductId is required.");
            RuleFor(x => x.Quantity).GreaterThan(0).WithMessage("Quantity must be greater than zero.");
        }
    }
}
