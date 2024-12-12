using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.UpdateCart
{
    public class UpdateCartCommandValidator : AbstractValidator<UpdateCartCommand>
    {
        public UpdateCartCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Cart Id is required.");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("UserId is required.");
            //RuleFor(x => x.Date).NotEmpty().WithMessage("Date is required.");
            RuleForEach(x => x.Products).SetValidator(new UpdateCartProductDtoValidator());
        }
    }

    //public class UpdateCartProductDtoValidator : AbstractValidator<UpdateCartProductDto>
    //{
    //    public UpdateCartProductDtoValidator()
    //    {
    //        RuleFor(x => x.ProductId).NotEmpty().WithMessage("ProductId is required.");
    //        RuleFor(x => x.Quantity).GreaterThan(0).WithMessage("Quantity must be greater than zero.");
    //    }
    //}
}
