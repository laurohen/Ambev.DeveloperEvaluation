using Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.Queries.GetProductCategories
{
    /// <summary>
    /// Handler for GetProductCategoriesQuery.
    /// </summary>
    public class GetProductCategoriesHandler : IRequestHandler<GetProductCategoriesQuery, List<string>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductCategoriesHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public async Task<List<string>> Handle(GetProductCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetCategoriesAsync(cancellationToken);
        }
    }

}
