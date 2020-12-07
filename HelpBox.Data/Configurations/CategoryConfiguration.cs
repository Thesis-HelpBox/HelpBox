using HelpBox.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpBox.Data.Configurations
{
    class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //(x category nesnesini temsil ediyor)
            //Id'yi primary key yap
            builder.HasKey(x => x.Id);
            //Id bir bir artsın
            builder.Property(x => x.Id).UseIdentityColumn();
            //Name zorunlu alan olsun ve max uzunluğu 200 olsun
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
           
        }
    }
}
