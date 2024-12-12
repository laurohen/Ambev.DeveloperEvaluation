using Ambev.DeveloperEvaluation.Application.Categories.DTOs;
using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Categories.Queries.ListCategories
{
    /// <summary>
    /// Profile for ListCategories mapping.
    /// </summary>
    public class ListCategoriesProfile : Profile
    {
        public ListCategoriesProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<PaginatedList<Category>, ListCategoriesResult>();
        }
    }
}
