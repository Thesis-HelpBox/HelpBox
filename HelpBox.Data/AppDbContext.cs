using HelpBox.Core.Models;
using HelpBox.Data.Configurations;
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
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductionRequest> ProductionRequests { get; set; }
        public DbSet<Sender> Senders { get; set; }
        public DbSet<User> Users { get; set; }

        //Veritabanında tablolar oluşmadan önce çalışacak olan metot
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfigution());
            modelBuilder.ApplyConfiguration(new ProductionRequestConfiguration());
            modelBuilder.ApplyConfiguration(new SenderConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            
        }
    }
}
