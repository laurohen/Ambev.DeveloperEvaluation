using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Categories.Commands.DeleteCategory
{
    /// <summary>
    /// Command for deleting a category.
    /// </summary>
    public record DeleteCategoryCommand(Guid Id) : IRequest<DeleteCategoryResult>;
}
