using Ambev.DeveloperEvaluation.Domain.Models.SaleAggregate.Validation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.Commands.CreateSale
{
    public class CreateSaleCommandValidator : AbstractValidator<CreateSaleCommand>
    {
        public CreateSaleCommandValidator()
        {
            RuleFor(sale => sale.SaleNumber).NotEmpty().NotNull().Length(1, 50);
            RuleFor(sale => sale.TotalAmount).NotEmpty().NotEqual(0);
            RuleFor(x => x.Items)
                .NotEmpty().WithMessage("Items cannot be empty")
                .Must(items => items != null && items.Any()).WithMessage("Sale must contain at least one item")
                .ForEach(item => item.SetValidator(new SaleItemDtoValidator()));
        }
    }
}
