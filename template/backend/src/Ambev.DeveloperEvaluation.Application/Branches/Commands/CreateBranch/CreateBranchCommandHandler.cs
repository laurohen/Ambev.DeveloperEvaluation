using Ambev.DeveloperEvaluation.Domain.Models.BranchAggregate;
using Ambev.DeveloperEvaluation.Domain.Models.BranchAggregate.Entities;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branchs.Commands.CreateBranch
{
    public class CreateBranchCommandHandler(IBranchRepository branchRepository, IMapper mapper)
    : IRequestHandler<CreateBranchCommand, CreateBranchResult>
    {
        public async Task<CreateBranchResult> Handle(CreateBranchCommand command, CancellationToken cancellationToken)
        {
            var validator = new CreateBranchCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var branch = mapper.Map<Branch>(command);

            var createdBranch = await branchRepository.CreateAsync(branch, cancellationToken);
            var result = mapper.Map<CreateBranchResult>(createdBranch);
            return result;
        }
    }
}
