﻿using Infrastructure.Features.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SalesApi.Models.Settings
{
    public class ProductConfiguration : EntityBaseConfiguration<Product>
    {
        public override void ConfigureDerived(EntityTypeBuilder<Product> b)
        {
            b.Property(x => x.Name).IsRequired().HasMaxLength(10);
            b.Property(x => x.FullName).IsRequired().HasMaxLength(50);
            b.Property(x => x.Specification).IsRequired().HasMaxLength(50);
            b.Property(x => x.EquivalentTon).HasColumnType("decimal(7, 6)");
            b.Property(x => x.Barcode).HasMaxLength(20);
            b.Property(x => x.TaxRate).HasColumnType("decimal(7, 6)");
        }
    }
}