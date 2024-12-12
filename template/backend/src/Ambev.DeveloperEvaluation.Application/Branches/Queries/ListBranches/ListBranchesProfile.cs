using Ambev.DeveloperEvaluation.Application.Branchs.DTOs;
using Ambev.DeveloperEvaluation.Domain.Models.BranchAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branches.Queries.ListBranches
{
    public class ListBranchesProfile : Profile
    {
        public ListBranchesProfile()
        {
            CreateMap<Branch, BranchDto>();
        }
    }
}
