using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Categories.Queries.GetCategories
{
    // <summary>
    /// Profile for GetCategory mapping.
    /// </summary>
    public class GetCategoryProfile : Profile
    {
        public GetCategoryProfile()
        {
            CreateMap<Category, GetCategoryResult>();
        }
    }
}
