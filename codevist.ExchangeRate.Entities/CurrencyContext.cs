using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codevist.ExchangeRate.Entities.Model;


namespace codevist.ExchangeRate.Entities
{
    public class CurrencyContext : DbContext
    {
        public CurrencyContext() : base("name=CurrencyContext")
        {
            this.Configuration.AutoDetectChangesEnabled = false;
        }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<ExchangeRateData> ExchangeRate { get; set; }
        public DbSet<ExchangeRateHistory> ExchangeRateHistory { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new CurrencyConfiguration());
            modelBuilder.Configurations.Add(new ExchangeRateHistoryConfiguration());
            modelBuilder.Configurations.Add(new ExchangeRateConfiguration());


            modelBuilder.Entity<ExchangeRateData>().Property(p => p.Buying).HasPrecision(18, 4);
            modelBuilder.Entity<ExchangeRateData>().Property(p => p.Selling).HasPrecision(18, 4);
            modelBuilder.Entity<ExchangeRateData>().Property(p => p.ChangeRate).HasPrecision(18, 4);

            modelBuilder.Entity<ExchangeRateHistory>().Property(p => p.Buying).HasPrecision(18, 4);
            modelBuilder.Entity<ExchangeRateHistory>().Property(p => p.Selling).HasPrecision(18, 4);
            modelBuilder.Entity<ExchangeRateHistory>().Property(p => p.ChangeRate).HasPrecision(18, 4);
        }
    }
}
