using Ambev.DeveloperEvaluation.Domain.Models.BranchAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branches.Commands.UpdateBranch
{
    public class UpdateBranchProfile : Profile
    {
        public UpdateBranchProfile()
        {
            CreateMap<UpdateBranchCommand, Branch>();
            CreateMap<Branch, UpdateBranchResult>();
        }
    }
}
