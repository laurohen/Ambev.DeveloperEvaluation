using Ambev.DeveloperEvaluation.Application.Categories.Commands.DeleteCategory;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Categories.DeleteCategory
{
    /// <summary>
    /// Profile for mapping DeleteCategory operations.
    /// </summary>
    public class DeleteCategoryProfile : Profile
    {
        public DeleteCategoryProfile()
        {
            CreateMap<DeleteCategoryRequest, DeleteCategoryCommand>()
                .ConstructUsing(src => new DeleteCategoryCommand(src.Id));
        }
    }

}
