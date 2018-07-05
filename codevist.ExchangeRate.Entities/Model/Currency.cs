using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codevist.ExchangeRate.Entities.Model
{
    public class Currency
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //Disable AutoInc
        public int CurrencyCode { get; set; }  // 949-TL 

        public int Id { get; set; }

        [StringLength(20)]
        public string CurrencySymbol { get; set; } //TL, USD
        [StringLength(75)]
        [Required]
        public string CurrencyName { get; set; } // Turk Lirası 

        public DateTime CreatedDate { get; set; }

        public virtual ICollection<ExchangeRateData> ExchangeRates { get; set; }
        public virtual ICollection<ExchangeRateHistory> ExchangeRateHistories { get; set; }
    }

    public class CurrencyConfiguration : EntityTypeConfiguration<Currency>
    {
        public CurrencyConfiguration()
        {
            HasMany(e => e.ExchangeRateHistories)
                .WithRequired(e => e.Currency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);

            HasMany(e => e.ExchangeRates)
                .WithRequired(e => e.Currency)
                .HasForeignKey(e => e.CurrencyCode)
                .WillCascadeOnDelete(false);
        }

    }
}
