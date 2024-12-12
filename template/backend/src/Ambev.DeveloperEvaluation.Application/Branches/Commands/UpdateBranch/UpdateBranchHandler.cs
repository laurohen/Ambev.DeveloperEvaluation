using Ambev.DeveloperEvaluation.Domain.Models.BranchAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branches.Commands.UpdateBranch
{
    public class UpdateBranchHandler : IRequestHandler<UpdateBranchCommand, UpdateBranchResult>
    {
        private readonly IBranchRepository _branchRepository;

        public UpdateBranchHandler(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository ?? throw new ArgumentNullException(nameof(branchRepository));
        }

        public async Task<UpdateBranchResult?> Handle(UpdateBranchCommand request, CancellationToken cancellationToken)
        {
            var branch = await _branchRepository.GetByIdAsync(request.Id, cancellationToken);

            if (branch == null)
                return null;

            branch.UpdateDetails(request.Name, request.Location);
            await _branchRepository.UpdateAsync(branch, cancellationToken);

            return new UpdateBranchResult
            {
                Id = branch.Id,
                Name = branch.Name,
                Location = branch.Location
            };
        }

    }
}
