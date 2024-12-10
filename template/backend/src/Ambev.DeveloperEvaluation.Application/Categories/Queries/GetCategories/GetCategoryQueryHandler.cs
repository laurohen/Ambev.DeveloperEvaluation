using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Categories.Queries.GetCategories
{
    /// <summary>
    /// Handler for processing GetCategoryQuery requests.
    /// </summary>
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, GetCategoryResult?>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCategoryQueryHandler"/> class.
        /// </summary>
        /// <param name="categoryRepository">The repository to access category data.</param>
        /// <param name="mapper">The mapper for converting entities to result DTOs.</param>
        public GetCategoryQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Handles the GetCategoryQuery request.
        /// </summary>
        /// <param name="request">The query containing the category ID.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The category result if found; otherwise, null.</returns>
        public async Task<GetCategoryResult?> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            // Fetch the category by ID
            var category = await _categoryRepository.GetByIdAsync(request.Id, cancellationToken);

            // If not found, return null
            if (category == null)
            {
                return null;
            }

            // Map the entity to the result DTO
            return _mapper.Map<GetCategoryResult>(category);
        }
    }
}
