using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate.Entities;
using System;

namespace Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate.Entities;

/// <summary>
/// Represents a product in the domain.
/// </summary>
public class Product : BaseEntity
{
    public string Title { get; private set; } = string.Empty;
    public decimal Price { get; private set; }
    public string Description { get; private set; } = string.Empty;
    public string Image { get; private set; } = string.Empty;
    public double Rate { get; private set; }
    public int Count { get; private set; }
    public Guid CategoryId { get; private set; }
    public Category Category { get; private set; } = null!;

    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; private set; }

    private Product() { }

    public Product(string title, decimal price, string description, string image, double rate, int count, Guid categoryId)
    {
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title is required", nameof(title));
        if (price <= 0) throw new ArgumentException("Price must be greater than zero", nameof(price));
        if (categoryId == Guid.Empty) throw new ArgumentException("Category ID is required", nameof(categoryId));

        Title = title;
        Price = price;
        Description = description;
        Image = image;
        Rate = rate;
        Count = count;
        CategoryId = categoryId;
    }

        public void UpdateDetails(string title,
        decimal price,
        string description,
        string image,
        Guid categoryId,
        double rate,
        int count)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title is required", nameof(title));
            if (price <= 0) throw new ArgumentException("Price must be greater than zero", nameof(price));
            if (categoryId == Guid.Empty) throw new ArgumentException("Category ID is required", nameof(categoryId));

            Title = title;
            Price = price;
            Description = description;
            Image = image;
            CategoryId = categoryId;
            Rate = rate;
            Count = count;
            UpdatedAt = DateTime.UtcNow;
        }

    public void UpdateRating(double rate, int count)
    {
        Rate = rate;
        Count = count;
        UpdatedAt = DateTime.UtcNow;
    }

    public void AssignCategory(Guid categoryId)
    {
        if (categoryId == Guid.Empty)
            throw new ArgumentException("Category ID cannot be empty.", nameof(categoryId));

        CategoryId = categoryId;
    }

}
