using Ambev.DeveloperEvaluation.Application.Branchs.DTOs;
using Ambev.DeveloperEvaluation.Domain.Models.BranchAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branches.Queries.ListBranches
{
    public class ListBranchesHandler : IRequestHandler<ListBranchesQuery, ListBranchesResult>
    {
        private readonly IBranchRepository _branchRepository;

        public ListBranchesHandler(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository ?? throw new ArgumentNullException(nameof(branchRepository));
        }

        public async Task<ListBranchesResult> Handle(ListBranchesQuery request, CancellationToken cancellationToken)
        {
            var branches = await _branchRepository.GetPagedAsync(request.Page, request.Size, cancellationToken);

            return new ListBranchesResult
            {
                Branches = branches.Select(b => new BranchDto
                {
                    Id = b.Id,
                    Name = b.Name,
                    Location = b.Location
                }).ToList(),
                TotalCount = await _branchRepository.GetCountAsync(cancellationToken)
            };
        }
    }
}
