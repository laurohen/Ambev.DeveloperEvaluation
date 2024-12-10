using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.Queries.GetProductCategories
{
    /// <summary>
    /// Query to retrieve all product categories.
    /// </summary>
    public class GetProductCategoriesQuery : IRequest<List<string>>
    {
    }
}
