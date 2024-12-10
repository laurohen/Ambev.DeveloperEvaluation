﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Models.BranchAggregate.Entities;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.ToTable("Branchs");

            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

            builder.Property(s => s.Name).IsRequired().HasMaxLength(50);
            builder.Property(s => s.Location).IsRequired().HasMaxLength(100);
            builder.Property(u => u.CreatedAt).HasColumnType("timestamp with time zone")
                .HasDefaultValueSql("CURRENT_TIMESTAMP").IsRequired();
            builder.Property(u => u.UpdatedAt).HasColumnType("timestamp with time zone");
        }
    }
}