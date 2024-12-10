﻿using Ambev.DeveloperEvaluation.Application.Branches.Commands.UpdateBranch;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.UpdateBranch
{
    public class UpdateBranchProfile : Profile
    {
        public UpdateBranchProfile()
        {
            CreateMap<UpdateBranchRequest, UpdateBranchCommand>();
            CreateMap<UpdateBranchResult, UpdateBranchResponse>();
        }
    }
}