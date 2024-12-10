using Ambev.DeveloperEvaluation.Domain.Models.CustomerAggregate;
using Ambev.DeveloperEvaluation.Domain.Models.CustomerAggregate.Entities;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper, IMediator mediator)
    : IRequestHandler<CreateCustomerCommand, CreateCustomerResult>
    {
        public async Task<CreateCustomerResult> Handle(CreateCustomerCommand command, CancellationToken cancellationToken)
        {
            var validator = new CreateCustomerCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var createdUser = await mediator.Send(command.UserCommand, cancellationToken);

            var customer = mapper.Map<Customer>(command);

            customer.SetUserId(createdUser.Id);

            var createdCustomer = await customerRepository.CreateAsync(customer, cancellationToken);
            var result = mapper.Map<CreateCustomerResult>(createdCustomer);
            return result;
        }
    }
}
