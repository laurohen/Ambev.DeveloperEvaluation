using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branches.Queries.GetBranch
{
    /// <summary>
    /// Query for retrieving a single branch by its ID.
    /// </summary>
    public sealed record GetBranchQuery(Guid Id) : IRequest<GetBranchResult>;
}
