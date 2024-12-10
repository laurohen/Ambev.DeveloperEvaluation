﻿using Ambev.DeveloperEvaluation.Domain.Models.SaleAggregate.Validation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.Commands.UpdateSale
{
    public class UpdateSaleCommandValidator : AbstractValidator<UpdateSaleCommand>
    {
        public UpdateSaleCommandValidator()
        {
            RuleFor(sale => sale.Id).NotEmpty().WithMessage("Id cannot be empty.");
            RuleFor(sale => sale.SaleNumber).NotEmpty().NotNull().Length(1, 50);
            RuleFor(sale => sale.TotalAmount).NotEmpty().GreaterThan(0);
            RuleFor(x => x.Items)
                .NotEmpty().WithMessage("Items cannot be empty")
                .Must(items => items != null && items.Any()).WithMessage("Sale must contain at least one item")
                .ForEach(item => item.SetValidator(new SaleItemDtoValidator()));
        }
    }
}