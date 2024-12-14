using Ambev.DeveloperEvaluation.Domain.Models.BranchAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branches.Commands.Delete_Branch
{
    public class DeleteBranchHandler : IRequestHandler<DeleteBranchCommand, DeleteBranchResult>
    {
        private readonly IBranchRepository _branchRepository;

        public DeleteBranchHandler(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository ?? throw new ArgumentNullException(nameof(branchRepository));
        }

        public async Task<DeleteBranchResult> Handle(DeleteBranchCommand request, CancellationToken cancellationToken)
        {
            var branch = await _branchRepository.GetByIdAsync(request.Id, cancellationToken);

            if (branch == null)
            {
                throw new KeyNotFoundException($"Branch with ID {request.Id} not found.");
            }

            await _branchRepository.DeleteAsync(branch.Id, cancellationToken);
            return new DeleteBranchResult { Success = true };
        }
    }
}
