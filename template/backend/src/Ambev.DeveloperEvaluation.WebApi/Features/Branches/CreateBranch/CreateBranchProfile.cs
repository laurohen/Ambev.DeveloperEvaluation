using Ambev.DeveloperEvaluation.Application.Branchs.Commands.CreateBranch;
using Ambev.DeveloperEvaluation.WebApi.Features.Branches.CreateBranch;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.CreateBranch;

public class CreateBranchProfile : Profile
{
    public CreateBranchProfile()
    {
        CreateMap<CreateBranchRequest, CreateBranchCommand>().ReverseMap();
        CreateMap<CreateBranchResult, CreateBranchResponse>().ReverseMap();
    }
}