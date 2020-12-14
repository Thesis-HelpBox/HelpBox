using HelpBox.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpBox.Data.Configurations
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //(x category nesnesini temsil ediyor)
            //Id'yi primary key yap
            builder.HasKey(x => x.Id);
            //Id bir bir artsın
            builder.Property(x => x.Id).UseIdentityColumn();
            //Name zorunlu alan olsun ve max uzunluğu 200 olsun
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.UserType).IsRequired();

            builder.Property(x => x.UserName).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(200);
            builder.Property(x => x.IdentityNumber).IsRequired().HasMaxLength(200);
            builder.Property(x => x.UserDoc).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Communication).IsRequired().HasMaxLength(200);
            builder.Property(x => x.City).IsRequired().HasMaxLength(200);
            builder.Property(x => x.District).IsRequired().HasMaxLength(200);

            builder.ToTable("Categories");
        }
    }
}
