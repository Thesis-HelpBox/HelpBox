using HelpBox.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpBox.Data.Configurations
{
    class ProductionRequestConfiguration : IEntityTypeConfiguration<ProductionRequest>
    {
        public void Configure(EntityTypeBuilder<ProductionRequest> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.CustomerId).IsRequired();

            builder.Property(x => x.SenderId).IsRequired();
            
            builder.Property(x => x.ProductId).IsRequired();

            builder.Property(x => x.ProductRequestDate);

            builder.ToTable("ProductionRequest");
        }
    }
}
