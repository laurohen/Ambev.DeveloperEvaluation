using Ambev.DeveloperEvaluation.Common.Validation;
using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Categories.Commands.DeleteCategory
{
    /// <summary>
    /// Handler for processing DeleteCategoryCommand.
    /// </summary>
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, DeleteCategoryResult>
    {
        private readonly ICategoryRepository _categoryRepository;

        public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        public async Task<DeleteCategoryResult> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var validator = new DeleteCategoryCommandValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                return new DeleteCategoryResult
                {
                    Success = false,
                    Message = "Validation failed",
                    Errors = validationResult.Errors.Select(e => new ValidationErrorDetail
                    {
                        PropertyName = e.PropertyName,
                        ErrorMessage = e.ErrorMessage
                    }).ToList()
                };
            }

            var category = await _categoryRepository.GetByIdAsync(request.Id, cancellationToken);
            if (category == null)
            {
                return new DeleteCategoryResult
                {
                    Success = false,
                    Message = $"Category with Id {request.Id} not found."
                };
            }

            var success = await _categoryRepository.DeleteAsync(category.Id, cancellationToken);

            if (!success)
            {
                return new DeleteCategoryResult
                {
                    Success = false,
                    Message = "Failed to delete the category."
                };
            }

            return new DeleteCategoryResult
            {
                Success = true,
                Message = "Category deleted successfully."
            };
        }
    

    }
}
