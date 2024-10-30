using MarketDemo.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace MarketDemo.Context
{
    public class dbcontainer: DbContext
    {
        public dbcontainer(DbContextOptions<dbcontainer> options):base(options)
        {
            
        }
        

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Sales> Sales { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=DESKTOP-47RDCTV;database=Market;integrated security=true");
        //}

    }
}
