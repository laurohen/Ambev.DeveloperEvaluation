namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.ListBranches
{
    public class ListBranchesResponse
    {
        //public IEnumerable<BranchResponse> Branches { get; set; } = Enumerable.Empty<BranchResponse>();
        public List<BranchResponse> Categories { get; set; } = new List<BranchResponse>();
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

    public class BranchResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
    }
}
