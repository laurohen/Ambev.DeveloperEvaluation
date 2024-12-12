using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var category = await _categoryRepository.GetByIdAsync(request.Id, cancellationToken);

            if (category == null)
            {
                return new DeleteCategoryResult { Success = false };
            }

            await _categoryRepository.DeleteAsync(category.Id, cancellationToken);

            return new DeleteCategoryResult { Success = true };
        }

        //public async Task<DeleteCategoryResult> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        //{
        //    var category = await _categoryRepository.GetByIdAsync(request.Id, cancellationToken);
        //    if (category == null)
        //    {
        //        throw new KeyNotFoundException($"Category with ID {request.Id} not found.");
        //    }

        //    var success = await _categoryRepository.DeleteAsync(request.Id, cancellationToken);
        //    return new DeleteCategoryResult { Success = success };
        //}
    }
}
