using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class CurrencyConverter
    {
        private IEnumerable<ExchangeRate> _exchangeRate;

        private CurrencyConverter() 
        {

            LoadExchangeRate();
        }

        //private static CurrencyConverter _instance = new ();
        private static CurrencyConverter _instance;

        private static object _lock = new object();
        public static CurrencyConverter Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new();
                    }
                }
                return _instance;
            }
        }

        private void LoadExchangeRate()
        {
            Thread.Sleep(3000);
            _exchangeRate = new[]
            {
                new ExchangeRate("USD","SAR",3.75m),
                new ExchangeRate("USD","EGP",30.60m),
                new ExchangeRate("SAR","EGP",8.165m),
            };
        }

        public decimal Convert(string baseCurrency, string targetCurrency, decimal amount)
        {
            var exchangeRate = _exchangeRate.FirstOrDefault(rate=> rate.BaseCurrency == baseCurrency && rate.TargetCurrency == targetCurrency);
            return amount * exchangeRate.Rate;
        }
    }
}
