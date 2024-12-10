using Ambev.DeveloperEvaluation.Application.Categories.Queries.ListCategories;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Categories.ListCategories
{
    /// <summary>
    /// Profile for mapping ListCategories operations.
    /// </summary>
    public class ListCategoriesProfile : Profile
    {
        public ListCategoriesProfile()
        {
            CreateMap<ListCategoriesResult, ListCategoriesResponse>();
        }
    }
}
