using Ambev.DeveloperEvaluation.Application.Users.CreateUser;
using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.Commands.CreateCustomer
{
    public sealed record CreateCustomerCommand(
    CreateUserCommand UserCommand,
    string Name,
    string ExternalId) : IRequest<CreateCustomerResult>
    {
        public CreateCustomerCommand() : this(default, string.Empty, string.Empty)
        {
        }

        public ValidationResultDetail Validate()
        {
            var validator = new CreateCustomerCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
