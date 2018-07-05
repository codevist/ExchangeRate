using System;
using System.Linq;
using System.Net;
using codevist.ExchangeRate.Entities;
using codevist.ExchangeRate.Entities.Model;
using Newtonsoft.Json;

namespace codevist.ExchangeRate.Web.Helper
{
    public class ProjectFunctions
    {
        public static void UpdateExchangeRate()
        {
            string currencyJsonUrl = "https://www.doviz.com/api/v1/currencies/all/latest";
            string currencyJsonSerializeList;
            using (CurrencyContext context= new CurrencyContext() )
            {
                using (var webClient = new WebClient())
                {
                    currencyJsonSerializeList = webClient.DownloadString(currencyJsonUrl);
                }
                dynamic currencyDeserializeList = JsonConvert.DeserializeObject(currencyJsonSerializeList);
                context.Database.ExecuteSqlCommand("Delete From ExchangeRateData");
                foreach (var currencyDeserializeItem in currencyDeserializeList)
                {
                   
                 
                            ExchangeRateData exchangeRate = new Entities.Model.ExchangeRateData
                            {
                                Id = currencyDeserializeItem.currency,
                                CurrencyCode = Iso4217CurrencyCodeList.GetCurrencyCode(currencyDeserializeItem.code.ToString()),
                                Buying = currencyDeserializeItem.buying,
                                Selling = currencyDeserializeItem.selling,
                                Name = currencyDeserializeItem.name,
                                FullName = currencyDeserializeItem.full_name,
                                ChangeRate = currencyDeserializeItem.change_rate,
                                CreatedDate = DateTime.Now,

                            };

                            context.ExchangeRate.Add(exchangeRate);
                            var exchangeRateHistory =
                                new ExchangeRateHistory
                                {
                                    CurrencyCode = exchangeRate.CurrencyCode,
                                    Buying = exchangeRate.Buying,
                                    Selling = exchangeRate.Selling,
                                    ChangeRate = exchangeRate.ChangeRate,
                                    Name = currencyDeserializeItem.name,
                                    FullName = currencyDeserializeItem.full_name,
                                    CreatedDate = DateTime.Now
                                };
                            context.ExchangeRateHistory.Add(exchangeRateHistory);
                    
                }
                context.SaveChanges();
            }
        }
    }
}