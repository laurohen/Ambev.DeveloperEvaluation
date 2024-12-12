using Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    /// <summary>
    /// Configuration for ProductRating entity.
    /// </summary>
    public class ProductRatingConfiguration : IEntityTypeConfiguration<ProductRating>
    {
        public void Configure(EntityTypeBuilder<ProductRating> builder)
        {
            builder.HasKey(pr => pr.Id);

            builder.Property(pr => pr.Rate)
                .IsRequired()
                .HasPrecision(3, 1);

            builder.Property(pr => pr.Count)
                .IsRequired();

            builder.Property(pr => pr.ProductId)
                .IsRequired();

            builder.HasOne<Product>()
            .WithOne()
            .HasForeignKey<ProductRating>(pr => pr.ProductId);

            //builder.HasOne<Product>() 
            //    .WithMany()
            //    .HasForeignKey(pr => pr.ProductId)
            //    .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("ProductRatings");
        }
    }
}
