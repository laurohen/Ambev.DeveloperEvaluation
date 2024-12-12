using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Categories.Commands.CreateCategory
{
    /// <summary>
    /// Profile for CreateCategory mapping.
    /// </summary>
    public class CreateCategoryProfile : Profile
    {
        public CreateCategoryProfile()
        {
            CreateMap<CreateCategoryCommand, Category>();
            CreateMap<Category, CreateCategoryResult>();
        }
    }
}
