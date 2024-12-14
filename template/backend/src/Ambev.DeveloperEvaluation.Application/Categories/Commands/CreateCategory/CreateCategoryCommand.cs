using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Categories.Commands.CreateCategory
{
    /// <summary>
    /// Command for creating a category.
    /// </summary>
    public record CreateCategoryCommand(string Name, string Description) : IRequest<CreateCategoryResult>;
}
