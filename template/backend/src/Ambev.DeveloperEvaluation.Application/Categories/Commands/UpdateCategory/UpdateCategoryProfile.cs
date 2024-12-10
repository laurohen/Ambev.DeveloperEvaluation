using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Categories.Commands.UpdateCategory
{
    /// <summary>
    /// Profile for UpdateCategory mapping.
    /// </summary>
    public class UpdateCategoryProfile : Profile
    {
        public UpdateCategoryProfile()
        {
            CreateMap<UpdateCategoryCommand, Category>();
            CreateMap<Category, UpdateCategoryResult>();
        }
    }
}
