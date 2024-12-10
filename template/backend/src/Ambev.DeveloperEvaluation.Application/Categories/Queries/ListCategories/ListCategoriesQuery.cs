using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Categories.Queries.ListCategories
{
    public record ListCategoriesQuery(int Page, int Size, string? Order = null) : IRequest<ListCategoriesResult>;
}
