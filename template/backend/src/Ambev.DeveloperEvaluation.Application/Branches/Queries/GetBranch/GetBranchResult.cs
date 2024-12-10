using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branches.Queries.GetBranch
{
    /// <summary>
    /// Represents the result of a GetBranch query.
    /// </summary>
    public class GetBranchResult
    {
        /// <summary>
        /// The unique identifier of the branch.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the branch.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The location of the branch.
        /// </summary>
        public string Location { get; set; } = string.Empty;

        /// <summary>
        /// The date and time when the branch was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the branch was last updated, if applicable.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }
    }
}
