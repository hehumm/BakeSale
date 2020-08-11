using BakeSale.Data;
using BakeSale.Data.Core;
using Infra.Common;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class BakeSaleDbContext : BaseDbContext<BakeSaleDbContext>
    {
        public BakeSaleDbContext(DbContextOptions<BakeSaleDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<CurrencyData> Currencies { get; set; }
        public DbSet<MoneyData> Money { get; set; }

        public DbSet<ProductData> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CurrencyData>().ToTable("CurrencyData");
            modelBuilder.Entity<MoneyData>().ToTable("MoneyData");
            modelBuilder.Entity<ProductData>().ToTable("ProductData");
        }

    }
}
