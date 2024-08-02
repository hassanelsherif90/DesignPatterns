using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class ExchangeRate
    {
        public string BaseCurrency { get; }
        public string TargetCurrency { get; }
        public decimal Rate { get; }

        public ExchangeRate(string baseCurrency, string targetCurrency, decimal rate)
        {
            this.BaseCurrency = baseCurrency;
            this.TargetCurrency = targetCurrency;
            this.Rate = rate;
        }

        
    }
}
