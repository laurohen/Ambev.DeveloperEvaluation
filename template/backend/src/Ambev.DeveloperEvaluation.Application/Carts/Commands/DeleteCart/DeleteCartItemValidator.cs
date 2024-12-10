using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.DeleteCart
{
    public class DeleteCartItemValidator : AbstractValidator<DeleteCartItemCommand>
    {
        /// <summary>
        ///     Initializes validation rules for DeleteCartCommand
        /// </summary>
        public DeleteCartItemValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage("UserId is required");
            RuleFor(x => x.ProductId)
                .NotEmpty()
                .WithMessage("Product is required");
        }
    }
}
