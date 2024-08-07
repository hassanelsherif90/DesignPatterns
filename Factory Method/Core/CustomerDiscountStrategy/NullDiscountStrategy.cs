using StrategyPattern.Core.CustomerDiscountStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Core.CustomerDiscountStrategy
{
    internal class NullDiscountStrategy : ICustomerDiscountStrategy
    {
        public double CalculateDiscount(double totalprice)
        {
            return 0;
        }
    }
}
