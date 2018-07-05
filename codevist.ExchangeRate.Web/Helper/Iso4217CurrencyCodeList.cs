using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codevist.ExchangeRate.Web.Helper
{ 
    public class Iso4217CurrencyCodeList
    {
        // http://en.wikipedia.org/wiki/ISO_4217
        private static readonly List<Iso4217Definition> DefinitionCollection = new List<Iso4217Definition> {
        new Iso4217Definition("AED", 784),
        new Iso4217Definition("AFN", 971),
        new Iso4217Definition("ALL", 008),
        new Iso4217Definition("AMD", 051),
        new Iso4217Definition("ANG", 532),
        new Iso4217Definition("AOA", 973),
        new Iso4217Definition("ARS",032),
        new Iso4217Definition("AUD",036),
        new Iso4217Definition("AWG", 533),
        new Iso4217Definition("AZN", 944),
        new Iso4217Definition("BAM", 977),
        new Iso4217Definition("BBD", 052),
        new Iso4217Definition("BDT", 050),
        new Iso4217Definition("BGN", 975),
        new Iso4217Definition("BHD", 048),
        new Iso4217Definition("BIF", 108),
        new Iso4217Definition("BMD", 060),
        new Iso4217Definition("BND", 096),
        new Iso4217Definition("BOB", 068),
        new Iso4217Definition("BOV", 984),
        new Iso4217Definition("BRL", 986),
        new Iso4217Definition("BSD", 044),
        new Iso4217Definition("BTN", 064),
        new Iso4217Definition("BWP", 072),
        new Iso4217Definition("BYN", 933),
        new Iso4217Definition("BYR", 974),
        new Iso4217Definition("BZD", 084),
        new Iso4217Definition("CAD", 124),
        new Iso4217Definition("CDF", 976),
        new Iso4217Definition("CHE", 947),
        new Iso4217Definition("CHF", 756),
        new Iso4217Definition("CHW", 948),
        new Iso4217Definition("CLF", 990),
        new Iso4217Definition("CLP", 152),
        new Iso4217Definition("CNY", 156),
        new Iso4217Definition("COP", 170),
        new Iso4217Definition("COU", 970),
        new Iso4217Definition("CRC", 188),
        new Iso4217Definition("CUC", 931),
        new Iso4217Definition("CUP", 192),
        new Iso4217Definition("CVE", 132),
        new Iso4217Definition("CZK",203),
        new Iso4217Definition("DJF",262),
        new Iso4217Definition("DKK",208),
        new Iso4217Definition("DOP",214),
        new Iso4217Definition("DZD", 012),
        new Iso4217Definition("CSK",200),
        new Iso4217Definition("EGP", 818),
        new Iso4217Definition("ERN",32),
        new Iso4217Definition("ETB",30),
        new Iso4217Definition("EUR", 978),
        new Iso4217Definition("FJD",42),
        new Iso4217Definition("FKP",38),
        new Iso4217Definition("GBP", 826),
        new Iso4217Definition("GEL", 981),
        new Iso4217Definition("GHS", 936),
        new Iso4217Definition("GIP",92),
        new Iso4217Definition("GMD",70),
        new Iso4217Definition("GNF",24),
        new Iso4217Definition("GTQ",20),
        new Iso4217Definition("GYD",28),
        new Iso4217Definition("HKD",344),
        new Iso4217Definition("HNL",40),
        new Iso4217Definition("HRK", 191),
        new Iso4217Definition("HTG",32),
        new Iso4217Definition("HUF",348),
        new Iso4217Definition("IDR",360),
        new Iso4217Definition("ILS",376),
        new Iso4217Definition("INR",356),
        new Iso4217Definition("IQD",368),
        new Iso4217Definition("IRR",364),
        new Iso4217Definition("ISK",352),
        new Iso4217Definition("JMD",88),
        new Iso4217Definition("JOD", 400),
        new Iso4217Definition("JPY",392),
        new Iso4217Definition("KES", 404),
        new Iso4217Definition("KGS", 417),
        new Iso4217Definition("KHR", 116),
        new Iso4217Definition("KMF", 174),
        new Iso4217Definition("KPW", 408),
        new Iso4217Definition("KRW", 410),
        new Iso4217Definition("KWD", 414),
        new Iso4217Definition("KYD", 136),
        new Iso4217Definition("KZT",398),
        new Iso4217Definition("LAK", 418),
        new Iso4217Definition("LBP", 422),
        new Iso4217Definition("LKR", 144),
        new Iso4217Definition("LRD", 430),
        new Iso4217Definition("LSL", 426),
        new Iso4217Definition("LTL", 440),
        new Iso4217Definition("LVL", 428),
        new Iso4217Definition("LYD", 434),
        new Iso4217Definition("MAD", 504),
        new Iso4217Definition("MDL", 498),
        new Iso4217Definition("MGA", 969),
        new Iso4217Definition("MKD", 807),
        new Iso4217Definition("MMK", 104),
        new Iso4217Definition("MNT", 496),
        new Iso4217Definition("MOP", 446),
        new Iso4217Definition("MRO", 478),
        new Iso4217Definition("MUR", 480),
        new Iso4217Definition("MVR", 462),
        new Iso4217Definition("MWK", 454),
        new Iso4217Definition("MXN", 484),
        new Iso4217Definition("MXV", 979),
        new Iso4217Definition("MYR", 458),
        new Iso4217Definition("MZN", 943),
        new Iso4217Definition("NAD", 516),
        new Iso4217Definition("NGN", 566),
        new Iso4217Definition("NIO", 558),
        new Iso4217Definition("NOK", 578),
        new Iso4217Definition("NPR", 524),
        new Iso4217Definition("NZD", 554),
        new Iso4217Definition("OMR", 512),
        new Iso4217Definition("PAB", 590),
        new Iso4217Definition("PEN", 604),
        new Iso4217Definition("PGK", 598),
        new Iso4217Definition("PHP", 608),
        new Iso4217Definition("PKR", 586),
        new Iso4217Definition("PLN", 985),
        new Iso4217Definition("PYG", 600),
        new Iso4217Definition("QAR", 634),
        new Iso4217Definition("RON", 946),
        new Iso4217Definition("RSD", 941),
        new Iso4217Definition("RUB", 643),
        new Iso4217Definition("RWF", 646),
        new Iso4217Definition("SAR", 682),
        new Iso4217Definition("SBD", 90),
        new Iso4217Definition("SCR", 690),
        new Iso4217Definition("SDG", 938),
        new Iso4217Definition("SEK", 752),
        new Iso4217Definition("SGD", 702),
        new Iso4217Definition("SHP", 654),
        new Iso4217Definition("SLL", 694),
        new Iso4217Definition("SOS", 706),
        new Iso4217Definition("SRD", 968),
        new Iso4217Definition("SSP", 728),
        new Iso4217Definition("STD", 678),
        new Iso4217Definition("SYP", 760),
        new Iso4217Definition("SZL", 748),
        new Iso4217Definition("THB", 764),
        new Iso4217Definition("TJS", 972),
        new Iso4217Definition("TMT", 934),
        new Iso4217Definition("TND", 788),
        new Iso4217Definition("TOP", 776),
        new Iso4217Definition("TRY", 949),
        new Iso4217Definition("TTD", 780),
        new Iso4217Definition("TWD", 901),
        new Iso4217Definition("TZS", 834),
        new Iso4217Definition("UAH", 980),
        new Iso4217Definition("UGX", 800),
        new Iso4217Definition("USD", 840),
        new Iso4217Definition("USN", 997),
        new Iso4217Definition("USS", 998),
        new Iso4217Definition("UYI", 940),
        new Iso4217Definition("UYU", 858),
        new Iso4217Definition("UZS", 860),
        new Iso4217Definition("VEF", 937),
        new Iso4217Definition("VND", 704),
        new Iso4217Definition("VUV", 548),
        new Iso4217Definition("WST", 882),
        new Iso4217Definition("XAF", 950),
        new Iso4217Definition("XCD", 951),
        new Iso4217Definition("XOF", 952),
        new Iso4217Definition("XPF", 953),
        new Iso4217Definition("YER", 886),
        new Iso4217Definition("ZAR", 710),
        new Iso4217Definition("ZMW", 967)
    };
        public static int GetCurrencyCode(string countryCode)
        {
            var singleOrDefault = DefinitionCollection.SingleOrDefault(d => d.Code == countryCode);
            return singleOrDefault?.Number ?? 0;
        }
        public static string GetCurrencyName(int countryCode)
        {
            var singleOrDefault = DefinitionCollection.SingleOrDefault(d => d.Number == countryCode);
            return singleOrDefault?.Code ?? string.Empty;
        }
        public class Iso4217Definition
        {
            private readonly string _code;
            private readonly int _number;
            public string Code
            {
                get { return _code; }
            }
            public int Number
            {
                get { return _number; }
            }
            private Iso4217Definition() { }

            public Iso4217Definition(string code, int number)
            {
                _code = code;
                _number = number;
            }
        }
    }
}
