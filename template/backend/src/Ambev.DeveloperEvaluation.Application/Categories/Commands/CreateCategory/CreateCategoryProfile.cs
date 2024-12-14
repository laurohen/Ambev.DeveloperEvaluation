using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate.Entities;
using AutoMapper;

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
