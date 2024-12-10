using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Categories.Commands.CreateCategory
{
    /// <summary>
    /// Command for creating a category.
    /// </summary>
    public record CreateCategoryCommand(string Name, string Description) : IRequest<CreateCategoryResult>;
}
