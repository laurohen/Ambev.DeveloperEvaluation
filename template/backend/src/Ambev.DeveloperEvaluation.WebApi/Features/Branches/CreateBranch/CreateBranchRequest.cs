//namespace Ambev.DeveloperEvaluation.WebApi.Features.Branchs.CreateBranch
//{
//    public class CreateBranchRequest
//    {
//    }
//}

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.CreateBranch;

public sealed record CreateBranchRequest(string Name, string Location);