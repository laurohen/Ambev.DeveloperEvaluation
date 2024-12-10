using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Categories.Queries.GetCategories
{
    public record GetCategoryQuery(Guid Id) : IRequest<GetCategoryResult>;
}
