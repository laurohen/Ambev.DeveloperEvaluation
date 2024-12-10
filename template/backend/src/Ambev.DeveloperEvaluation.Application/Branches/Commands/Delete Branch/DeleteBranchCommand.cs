using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branches.Commands.Delete_Branch
{
    public sealed record DeleteBranchCommand(Guid Id) : IRequest<DeleteBranchResult>;
}
