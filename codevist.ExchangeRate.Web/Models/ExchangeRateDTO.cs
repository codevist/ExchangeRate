using codevist.ExchangeRate.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codevist.ExchangeRate.Web.Models
{
    public class ExchangeRateDTO
    {
        public List<ExchangeRateData> ExchangeRateDataList { get; set; }
    }
}