﻿using Ambev.DeveloperEvaluation.Domain.Models.BranchAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branches.Queries.GetBranch
{
    public class GetBranchProfile : Profile
    {
        public GetBranchProfile()
        {
            CreateMap<Branch, GetBranchResult>();
        }
    }
}
