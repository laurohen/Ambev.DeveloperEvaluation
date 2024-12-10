using Ambev.DeveloperEvaluation.Application.Branches.Queries.GetBranch;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branches.Queries.ListBranches
{
    /// <summary>
    /// Represents the result of a query to list branches.
    /// </summary>
    public class ListBranchesResult
    {
        /// <summary>
        /// The list of branches.
        /// </summary>
        public List<BranchDto> Branches { get; set; } = new();

        /// <summary>
        /// The total number of branches.
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Current page number.
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Total number of pages.
        /// </summary>
        public int TotalPages { get; set; }
    }

    /// <summary>
    /// Data Transfer Object (DTO) representing a branch.
    /// </summary>
    public class BranchDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
    }
}
