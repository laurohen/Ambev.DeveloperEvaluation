using Ambev.DeveloperEvaluation.Application.Categories.DTOs;
using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Categories.Queries.ListCategories
{
    public class ListCategoriesQueryHandler : IRequestHandler<ListCategoriesQuery, ListCategoriesResult>
    {
        private readonly ICategoryRepository _categoryRepository;

        public ListCategoriesQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        public async Task<ListCategoriesResult> Handle(ListCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository.GetCategoriesAsync(request.Page, request.Size, cancellationToken);
            var totalCount = await _categoryRepository.GetTotalCountAsync(cancellationToken);

            return new ListCategoriesResult
            {
                Categories = categories.Select(c => new CategoryDto { Id = c.Id, Name = c.Name, Description = c.Description }).ToList(),
                TotalCount = totalCount
            };
        }
    }
}
