using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate.Entities;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.Price)
                .IsRequired()
                .HasPrecision(18, 2);

            builder.Property(p => p.Description)
                .HasMaxLength(1000);

            builder.Property(p => p.Image)
                .HasMaxLength(500);

            // Configure the relationship with Category
            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .IsRequired();

            //builder.OwnsOne(p => p.Rating, rating =>
            //{
            //    rating.Property(r => r.Rate).HasPrecision(3, 2);
            //    rating.Property(r => r.Count).IsRequired();
            //});

            //builder.HasMany<ProductRating>()
            //   .WithOne()
            //   .HasForeignKey(pr => pr.ProductId)
            //   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<ProductRating>()
                .WithOne()
                .HasForeignKey<ProductRating>(pr => pr.ProductId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.Property(p => p.CreatedAt).IsRequired();

            builder.ToTable("Products");
        }
    }
}
