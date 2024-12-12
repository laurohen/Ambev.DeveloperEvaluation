using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Categories.Commands.DeleteCategory
{
    /// <summary>
    /// Profile for DeleteCategory mapping.
    /// </summary>
    public class DeleteCategoryProfile : Profile
    {
        public DeleteCategoryProfile()
        {
            CreateMap<Category, DeleteCategoryResult>();
        }
    }
}
