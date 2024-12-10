using Ambev.DeveloperEvaluation.Application.Categories.Commands.CreateCategory;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Categories.CreateCategory
{
    /// <summary>
    /// Profile for mapping CreateCategory operations.
    /// </summary>
    public class CreateCategoryProfile : Profile
    {
        public CreateCategoryProfile()
        {
            
            CreateMap<CreateCategoryRequest, CreateCategoryCommand>();
            CreateMap<CreateCategoryResult, CreateCategoryResponse>();
        }
    }
}
