using Ambev.DeveloperEvaluation.Application.Categories.Queries.GetCategories;
using Ambev.DeveloperEvaluation.Domain.Models.BranchAggregate;
using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branches.Queries.GetBranch
{
    public class GetBranchHandler : IRequestHandler<GetBranchQuery, GetBranchResult>
    {
        private readonly IBranchRepository _branchRepository;
        private readonly IMapper _mapper;

        public GetBranchHandler(IBranchRepository branchRepository, IMapper mapper)
        {
            _branchRepository = branchRepository ?? throw new ArgumentNullException(nameof(branchRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<GetBranchResult?> Handle(GetBranchQuery request, CancellationToken cancellationToken)
        {
            var branch = await _branchRepository.GetByIdAsync(request.Id, cancellationToken);

            if (branch == null)
            {
                return null;
            }

            return _mapper.Map<GetBranchResult>(branch);
        }
    }
}
