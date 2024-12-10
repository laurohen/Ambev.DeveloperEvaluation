using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branches.Commands.UpdateBranch
{
    /// <summary>
    /// Command for updating a branch.
    /// </summary>
    public sealed record UpdateBranchCommand : IRequest<UpdateBranchResult>
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public string Location { get; init; } = string.Empty;

        public UpdateBranchCommand() { }

        public UpdateBranchCommand(Guid id, string name, string location)
        {
            Id = id;
            Name = name;
            Location = location;
        }
    }
}
