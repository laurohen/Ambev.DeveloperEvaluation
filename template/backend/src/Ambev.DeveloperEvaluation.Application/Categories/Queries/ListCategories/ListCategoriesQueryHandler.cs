using Ambev.DeveloperEvaluation.Application.Categories.DTOs;
using Ambev.DeveloperEvaluation.Common.Validation;
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
            var validator = new ListCategoriesQueryValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                return new ListCategoriesResult
                {
                    Success = false,
                    Message = "Validation failed.",
                    Errors = validationResult.Errors.Select(e => new ValidationErrorDetail
                    {
                        PropertyName = e.PropertyName,
                        ErrorMessage = e.ErrorMessage
                    }).ToList()
                };
            }

            var categories = await _categoryRepository.GetCategoriesAsync(request.Page, request.Size, cancellationToken);
            var totalCount = await _categoryRepository.GetTotalCountAsync(cancellationToken);

            if (!categories.Any())
            {
                return new ListCategoriesResult
                {
                    Success = false,
                    Message = "No categories found for the given criteria."
                };
            }

            return new ListCategoriesResult
            {
                Success = true,
                Message = "Categories retrieved successfully.",
                Categories = categories.Select(c => new CategoryDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description
                }).ToList(),
                TotalCount = totalCount
            };

            //return new ListCategoriesResult
            //{
            //    Categories = categories.Select(c => new CategoryDto { Id = c.Id, Name = c.Name, Description = c.Description }).ToList(),
            //    TotalCount = totalCount
            //};
        }
    }
}
