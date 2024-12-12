using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate.Entities;
using System;

namespace Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate.Entities;

/// <summary>
/// Represents a product in the domain.
/// </summary>
//public class Product : BaseEntity
//{
//    public string Title { get; private set; } = string.Empty;
//    public decimal Price { get; private set; }
//    public string Description { get; private set; } = string.Empty;
//    public string Image { get; private set; } = string.Empty;
//    public ProductRating Rating { get; private set; } = new ProductRating(Guid.NewGuid(), 0, 0);

//    // Foreign key for the category
//    public Guid CategoryId { get; private set; }

//    // Navigation property for the category
//    public Category Category { get; private set; } = null!;

//    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
//    public DateTime? UpdatedAt { get; private set; }

//    private Product() { }
//    public Product(string title, decimal price, string description, string image, ProductRating rating, Guid categoryId)
//    {
//        Title = title;
//        Price = price;
//        Description = description;
//        Image = image;
//        Rating = rating;
//        CategoryId = categoryId;
//    }

//    public void UpdateDetails(string title, decimal price, string description, string image, Guid categoryId, ProductRating rating)
//    {
//        Title = title;
//        Price = price;
//        Description = description;
//        Image = image;
//        CategoryId = categoryId;
//        Rating = rating;
//        UpdatedAt = DateTime.UtcNow;
//    }

//    public void UpdateRating(ProductRating rating)
//    {
//        Rating = rating;
//        UpdatedAt = DateTime.UtcNow;
//    }
//}


public class Product : BaseEntity
{
    public string Title { get; private set; } = string.Empty;
    public decimal Price { get; private set; }
    public string Description { get; private set; } = string.Empty;
    public string Image { get; private set; } = string.Empty;
    public ProductRating Rating { get; private set; }
    public Guid CategoryId { get; private set; }
    public Category Category { get; private set; } = null!;

    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; private set; }

    private Product() { }

    public Product(string title, decimal price, string description, string image, ProductRating rating, Guid categoryId)
    {
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title is required", nameof(title));
        if (price <= 0) throw new ArgumentException("Price must be greater than zero", nameof(price));
        if (categoryId == Guid.Empty) throw new ArgumentException("Category ID is required", nameof(categoryId));

        Title = title;
        Price = price;
        Description = description;
        Image = image;
        Rating = rating ?? throw new ArgumentNullException(nameof(rating));
        CategoryId = categoryId;
    }

    public void UpdateDetails(string title, decimal price, string description, string image, Guid categoryId, ProductRating rating)
    {
        if (string.IsNullOrWhiteSpace(title)) throw new ArgumentException("Title is required", nameof(title));
        if (price <= 0) throw new ArgumentException("Price must be greater than zero", nameof(price));
        if (categoryId == Guid.Empty) throw new ArgumentException("Category ID is required", nameof(categoryId));

        Title = title;
        Price = price;
        Description = description;
        Image = image;
        CategoryId = categoryId;
        Rating = rating ?? throw new ArgumentNullException(nameof(rating));
        UpdatedAt = DateTime.UtcNow;
    }

    public void AssignCategory(Guid categoryId)
    {
        if (categoryId == Guid.Empty) throw new ArgumentException("Category ID cannot be empty", nameof(categoryId));
        CategoryId = categoryId;
    }
}
