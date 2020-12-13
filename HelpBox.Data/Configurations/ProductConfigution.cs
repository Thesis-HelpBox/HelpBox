using HelpBox.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpBox.Data.Configurations
{
    public class ProductConfigution : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //(x product nesnesini temsil ediyor)
            //Id'yi primary key yap
            builder.HasKey(x => x.Id);
            //Id bir bir artsın
            builder.Property(x => x.Id).UseIdentityColumn();
            //Name zorunlu alan olsun ve max uzunluğu 200 olsun
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            //Coupon zorunlu alan
            builder.Property(x => x.Coupon).IsRequired();

            builder.Property(x => x.Category).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.Photo).IsRequired();

            builder.ToTable("Products");
        }
    }
}
