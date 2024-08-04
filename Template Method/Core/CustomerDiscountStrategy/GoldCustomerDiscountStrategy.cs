using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Core.CustomerDiscountStrategy
{
    internal class GoldCustomerDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalprice)
        {
            return totalprice >= 10000 ? .1 : 0;
        }
    }
}
