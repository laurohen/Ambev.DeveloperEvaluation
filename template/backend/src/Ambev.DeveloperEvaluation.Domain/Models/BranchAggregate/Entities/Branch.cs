using Ambev.DeveloperEvaluation.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Models.BranchAggregate.Entities
{
    public class Branch : BaseEntity
    {
        public string Name { get; private set; } = string.Empty;
        public string Location { get; private set; } = string.Empty;
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; private set; }
        public Branch(string name, string location)
        {
            Name = name;
            Location = location;
        }

        private Branch() { }

        /// <summary>
        /// Updates the details of the branch.
        /// </summary>
        /// <param name="name">The new name of the branch.</param>
        /// <param name="location">The new location of the branch.</param>
        public void UpdateDetails(string name, string location)
        {
            Name = name;
            Location = location;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
