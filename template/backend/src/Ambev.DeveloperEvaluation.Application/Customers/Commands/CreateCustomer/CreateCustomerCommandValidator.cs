using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(customer => customer.Name).NotEmpty().NotNull().Length(3, 50);
            RuleFor(customer => customer.ExternalId).NotEmpty().NotNull().Length(1, 50);
        }
    }
}
