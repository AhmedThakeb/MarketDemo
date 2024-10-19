using MarketDemo.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace MarketDemo.Context
{
    public class dbcontainer: DbContext
    {

        internal object Invoices;

        public DbSet<Customers> Customer { get; set; }
        public DbSet<Invoices> Invoice { get; set; }
        public DbSet<Items> Item { get; set; }
        public DbSet<Orders> Order { get; set; }
        public DbSet<Sales> Sale { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-47RDCTV;database=Market;integrated security=true");
        }

    }
}
