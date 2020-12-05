using HelpBox.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpBox.Data
{
    public class AppDbContext:DbContext
    {
        //SQLdeki Veritabanı
        public AppDbContext(DbContextOptions<AppDbContext> options):base (options)
        { 
        }

        public DbSet<Category> Categories{ get; set; }
        public DbSet<Product> Products { get; set; }

        //Veritabanında metotlar oluşmadan önce çalışacak olan metot
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
