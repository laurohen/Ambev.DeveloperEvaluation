using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate.Entities;
using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate;
using AutoMapper;
using MediatR;
using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Application.Categories.DTOs;

namespace Ambev.DeveloperEvaluation.Application.Categories.Commands.CreateCategory
{
    /// <summary>
    /// Handler for processing CreateCategoryCommand.
    /// </summary>
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreateCategoryResult>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<CreateCategoryResult> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateCategoryCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                return new CreateCategoryResult
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

            var category = _mapper.Map<Category>(request);

            var createdCategory = await _categoryRepository.CreateAsync(category, cancellationToken);

            return new CreateCategoryResult
            {
                Success = true,
                Message = "Category created successfully.",
                Data = _mapper.Map<CategoryDto>(createdCategory)
            };
        }
    }
}
