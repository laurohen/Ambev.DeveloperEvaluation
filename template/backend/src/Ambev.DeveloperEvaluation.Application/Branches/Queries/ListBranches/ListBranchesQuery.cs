using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branches.Queries.ListBranches
{
    public sealed record ListBranchesQuery(int Page, int Size, string? Order = null) : IRequest<ListBranchesResult>;
}
