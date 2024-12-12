using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate.Entities;
using System.Collections.Generic;

namespace Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate.Entities;

/// <summary>
/// Represents a product category in the domain.
/// </summary>
public class Category : BaseEntity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; private set; }

    // Navigation property for related products
    public ICollection<Product> Products { get; private set; } = new List<Product>();

    public Category(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void UpdateDetails(string name, string description)
    {
        Name = name;
        Description = description;
        UpdatedAt = DateTime.UtcNow;
    }
}
