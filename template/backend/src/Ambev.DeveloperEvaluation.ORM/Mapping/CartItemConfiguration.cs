using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Models.CartAggregate.Entities;
using Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate.Entities;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.ToTable("CartItems");

            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

            builder.Property(u => u.ProductId).IsRequired();
            builder.Property(u => u.Quantity).IsRequired();
            builder.Property(u => u.CartId).IsRequired();

            builder.HasOne<Product>()
                .WithMany()
                .HasForeignKey(s => s.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(s => s.Cart)
                .WithMany(i => i.Products)
                .HasForeignKey(i => i.CartId);
        }
    }
}
