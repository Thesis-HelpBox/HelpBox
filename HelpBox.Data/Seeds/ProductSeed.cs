using HelpBox.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpBox.Data.Seeds
{
    class ProductSeed:IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;

        public ProductSeed(int[] Ids)
        {
            _ids = Ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id=1, Name="Gömlek", Coupon=30, CategoryId=1, IsActive=true, Description="Beyaz Gömlek", Photo=""}
                );
        }
    }
}
