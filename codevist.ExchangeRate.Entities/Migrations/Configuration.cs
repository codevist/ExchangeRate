namespace codevist.ExchangeRate.Entities.Migrations
{
    using codevist.ExchangeRate.Entities.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<codevist.ExchangeRate.Entities.CurrencyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(codevist.ExchangeRate.Entities.CurrencyContext context)
        {
            var createdDate = DateTime.Now;
            context.Currency.AddOrUpdate(x => x.Id,


                new Currency() { CreatedDate = createdDate, Id = 1, CurrencyCode = 949, CurrencyName = "Türk Lirasý", CurrencySymbol = "TRY" },
                new Currency { CreatedDate = createdDate, Id = 2, CurrencyCode = 840, CurrencyName = "Amerikan Dolarý", CurrencySymbol = "USD" },
                new Currency { CreatedDate = createdDate, Id = 3, CurrencyCode = 978, CurrencyName = "Euro", CurrencySymbol = "EUR" },
                new Currency { CreatedDate = createdDate, Id = 4, CurrencyCode = 826, CurrencyName = "Ýngiliz Sterlini", CurrencySymbol = "GBP" },
                new Currency { CreatedDate = createdDate, Id = 5, CurrencyCode = 756, CurrencyName = "Ýsviçre Frangý", CurrencySymbol = "CHF" },
                new Currency { CreatedDate = createdDate, Id = 6, CurrencyCode = 124, CurrencyName = "Kanada Dolarý", CurrencySymbol = "CAD" },
                new Currency { CreatedDate = createdDate, Id = 7, CurrencyCode = 643, CurrencyName = "Rus Rublesi", CurrencySymbol = "RUB" },
                new Currency { CreatedDate = createdDate, Id = 8, CurrencyCode = 784, CurrencyName = "B.A.E.Dirhemi", CurrencySymbol = "AED" },
                new Currency { CreatedDate = createdDate, Id = 9, CurrencyCode = 36, CurrencyName = "  Avustralya Dolarý", CurrencySymbol = "AUD" },
                new Currency { CreatedDate = createdDate, Id = 10, CurrencyCode = 208, CurrencyName = " Danimarka Kronu", CurrencySymbol = "DKK" },
                new Currency { CreatedDate = createdDate, Id = 11, CurrencyCode = 752, CurrencyName = "Ýsveç Kronu", CurrencySymbol = "SEK" },
                new Currency { CreatedDate = createdDate, Id = 12, CurrencyCode = 578, CurrencyName = "Norveç Kronu", CurrencySymbol = "NOK" },
                new Currency { CreatedDate = createdDate, Id = 13, CurrencyCode = 392, CurrencyName = "100 Japon Yeni", CurrencySymbol = "JPY" },
                new Currency { CreatedDate = createdDate, Id = 14, CurrencyCode = 414, CurrencyName = "Kuveyt Dinarý", CurrencySymbol = "KWD" },
                new Currency { CreatedDate = createdDate, Id = 15, CurrencyCode = 710, CurrencyName = "Güney Afrika Randý", CurrencySymbol = "ZAR" },
                new Currency { CreatedDate = createdDate, Id = 16, CurrencyCode = 48, CurrencyName = "Bahreyn Dinarý", CurrencySymbol = " BHD" },
                new Currency { CreatedDate = createdDate, Id = 17, CurrencyCode = 434, CurrencyName = "Libya Dinarý", CurrencySymbol = " LYD" },
                new Currency { CreatedDate = createdDate, Id = 18, CurrencyCode = 682, CurrencyName = "S.Arabistan Riyali", CurrencySymbol = " SAR" },
                new Currency { CreatedDate = createdDate, Id = 19, CurrencyCode = 368, CurrencyName = "Irak Dinarý", CurrencySymbol = " IQD" },
                new Currency { CreatedDate = createdDate, Id = 20, CurrencyCode = 376, CurrencyName = "Ýsrail Þekeli", CurrencySymbol = " ILS" },
                new Currency { CreatedDate = createdDate, Id = 21, CurrencyCode = 364, CurrencyName = "Ýran Riyali", CurrencySymbol = " IRR" },
                new Currency { CreatedDate = createdDate, Id = 22, CurrencyCode = 356, CurrencyName = "Hindistan Rupisi", CurrencySymbol = " INR" },
                new Currency { CreatedDate = createdDate, Id = 23, CurrencyCode = 484, CurrencyName = "Meksika Pesosu", CurrencySymbol = " MXN" },
                new Currency { CreatedDate = createdDate, Id = 24, CurrencyCode = 348, CurrencyName = "Macar Forinti", CurrencySymbol = " HUF" },
                new Currency { CreatedDate = createdDate, Id = 25, CurrencyCode = 554, CurrencyName = "Yeni Zelanda Dolarý", CurrencySymbol = " NZD" },
                new Currency { CreatedDate = createdDate, Id = 26, CurrencyCode = 986, CurrencyName = "Brezilya Reali", CurrencySymbol = " BRL" },
                new Currency { CreatedDate = createdDate, Id = 27, CurrencyCode = 360, CurrencyName = "Endonezya Rupiahi", CurrencySymbol = " IDR" },
                new Currency { CreatedDate = createdDate, Id = 28, CurrencyCode = 200, CurrencyName = "Çek Korunasý", CurrencySymbol = " CSK" },
                new Currency { CreatedDate = createdDate, Id = 29, CurrencyCode = 985, CurrencyName = "Polonya Zlotisi", CurrencySymbol = " PLN" },
                new Currency { CreatedDate = createdDate, Id = 30, CurrencyCode = 975, CurrencyName = "Bulgar Levasý", CurrencySymbol = " BGN" },
                new Currency { CreatedDate = createdDate, Id = 31, CurrencyCode = 946, CurrencyName = "Romanya Leyi", CurrencySymbol = " RON" },
                new Currency { CreatedDate = createdDate, Id = 32, CurrencyCode = 156, CurrencyName = "Çin Yuaný", CurrencySymbol = " CNY" },
                new Currency { CreatedDate = createdDate, Id = 33, CurrencyCode = 32, CurrencyName = "Arjantin Pesosu", CurrencySymbol = " ARS" },
                new Currency { CreatedDate = createdDate, Id = 34, CurrencyCode = 8, CurrencyName = "Arnavutluk Leki", CurrencySymbol = " ALL" },
                new Currency { CreatedDate = createdDate, Id = 35, CurrencyCode = 944, CurrencyName = "Azerbaycan Manatý", CurrencySymbol = " AZN" },
                new Currency { CreatedDate = createdDate, Id = 36, CurrencyCode = 977, CurrencyName = "Bosna - Hersek Marký", CurrencySymbol = " BAM" },
                new Currency { CreatedDate = createdDate, Id = 37, CurrencyCode = 974, CurrencyName = "Belarus Rublesi", CurrencySymbol = " BYR" },
                new Currency { CreatedDate = createdDate, Id = 38, CurrencyCode = 152, CurrencyName = "Þili Pesosu", CurrencySymbol = " CLP" },
                new Currency { CreatedDate = createdDate, Id = 39, CurrencyCode = 170, CurrencyName = "Kolombiya Pesosu", CurrencySymbol = " COP" },
                new Currency { CreatedDate = createdDate, Id = 40, CurrencyCode = 188, CurrencyName = "Kostarika Kolonu", CurrencySymbol = " CRC" },
                new Currency { CreatedDate = createdDate, Id = 41, CurrencyCode = 12, CurrencyName = "Cezayir Dinarý", CurrencySymbol = " DZD" },
                new Currency { CreatedDate = createdDate, Id = 42, CurrencyCode = 818, CurrencyName = "Mýsýr Lirasý", CurrencySymbol = " EGP" },
                new Currency { CreatedDate = createdDate, Id = 43, CurrencyCode = 344, CurrencyName = "Hong Kong Dolarý", CurrencySymbol = " HKD" },
                new Currency { CreatedDate = createdDate, Id = 44, CurrencyCode = 191, CurrencyName = "Hýrvat Kunasý", CurrencySymbol = " HRK" },
                new Currency { CreatedDate = createdDate, Id = 45, CurrencyCode = 352, CurrencyName = "Ýzlanda Kronasý", CurrencySymbol = " ISK" },
                new Currency { CreatedDate = createdDate, Id = 46, CurrencyCode = 400, CurrencyName = "Ürdün Dinarý", CurrencySymbol = " JOD" },
                new Currency { CreatedDate = createdDate, Id = 47, CurrencyCode = 410, CurrencyName = "Güney Kore Wonu", CurrencySymbol = " KRW" },
                new Currency { CreatedDate = createdDate, Id = 48, CurrencyCode = 398, CurrencyName = "Kazak Tengesi", CurrencySymbol = " KZT" },
                new Currency { CreatedDate = createdDate, Id = 49, CurrencyCode = 422, CurrencyName = "Lübnan Lirasý", CurrencySymbol = " LBP" },
                new Currency { CreatedDate = createdDate, Id = 50, CurrencyCode = 144, CurrencyName = "Sri Lanka Rupisi", CurrencySymbol = " LKR" },
                new Currency { CreatedDate = createdDate, Id = 51, CurrencyCode = 440, CurrencyName = "Litvanya Litasý", CurrencySymbol = " LTL" },
                new Currency { CreatedDate = createdDate, Id = 52, CurrencyCode = 428, CurrencyName = "Letonya Latsý", CurrencySymbol = " LVL" },
                new Currency { CreatedDate = createdDate, Id = 53, CurrencyCode = 504, CurrencyName = "Fas Dirhemi", CurrencySymbol = " MAD" },
                new Currency { CreatedDate = createdDate, Id = 54, CurrencyCode = 498, CurrencyName = "Moldovya Leusu", CurrencySymbol = " MDL" },
                new Currency { CreatedDate = createdDate, Id = 55, CurrencyCode = 807, CurrencyName = "Makedon Dinarý", CurrencySymbol = " MKD" },
                new Currency { CreatedDate = createdDate, Id = 56, CurrencyCode = 458, CurrencyName = "Malezya Ringgiti", CurrencySymbol = " MYR" },
                new Currency { CreatedDate = createdDate, Id = 57, CurrencyCode = 512, CurrencyName = "Umman Riyali", CurrencySymbol = " OMR" },
                new Currency { CreatedDate = createdDate, Id = 58, CurrencyCode = 604, CurrencyName = "Peru Ýnti", CurrencySymbol = " PEN" },
                new Currency { CreatedDate = createdDate, Id = 59, CurrencyCode = 608, CurrencyName = "Filipinler Pesosu", CurrencySymbol = " PHP" },
                new Currency { CreatedDate = createdDate, Id = 60, CurrencyCode = 586, CurrencyName = "Pakistan Rupisi", CurrencySymbol = " PKR" },
                new Currency { CreatedDate = createdDate, Id = 61, CurrencyCode = 634, CurrencyName = "Katar Riyali", CurrencySymbol = " QAR" },
                new Currency { CreatedDate = createdDate, Id = 62, CurrencyCode = 941, CurrencyName = "Sýrbistan Dinarý", CurrencySymbol = " RSD" },
                new Currency { CreatedDate = createdDate, Id = 63, CurrencyCode = 702, CurrencyName = "Singapur Dolarý", CurrencySymbol = " SGD" },
                new Currency { CreatedDate = createdDate, Id = 64, CurrencyCode = 760, CurrencyName = "Suriye Lirasý", CurrencySymbol = " SYP" },
                new Currency { CreatedDate = createdDate, Id = 65, CurrencyCode = 764, CurrencyName = "Tayland Bahtý", CurrencySymbol = " THB" },
                new Currency { CreatedDate = createdDate, Id = 66, CurrencyCode = 901, CurrencyName = "Yeni Tayvan Dolarý", CurrencySymbol = " TWD" },
                new Currency { CreatedDate = createdDate, Id = 67, CurrencyCode = 980, CurrencyName = "Ukrayna Grivnasý", CurrencySymbol = " UAH" },
                new Currency { CreatedDate = createdDate, Id = 68, CurrencyCode = 858, CurrencyName = "Uruguay Pesosu", CurrencySymbol = " UYU" }

            );
        }
    }
}
