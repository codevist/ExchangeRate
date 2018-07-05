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
    public class ExchangeRateData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //Disable AutoInc
        public int Id { get; set; }
        public int CurrencyCode { get; set; }
        public decimal ChangeRate { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }

        public decimal Buying { get; set; }
        public decimal Selling { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual Currency Currency { get; set; }
    }

    public class ExchangeRateConfiguration : EntityTypeConfiguration<ExchangeRateData>
    {
        public ExchangeRateConfiguration()
        {

        }
    }
}
