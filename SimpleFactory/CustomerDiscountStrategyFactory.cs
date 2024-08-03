using SimpleFactory.Core.CustomerDiscountStrategy;
using StrategyPattern.Core;
using StrategyPattern.Core.CustomerDiscountStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class CustomerDiscountStrategyFactory
    {
        public ICustomerDiscountStrategy CreateCustomerDiscountStrategyFactory(CustomerCategory Category)
        {
            if (Category == CustomerCategory.Gold)
            {
                return new GoldCustomerDiscountStrategy();
            }
            else if (Category == CustomerCategory.Silver)
            {
                return new SilverCustomerDiscountStrategy();
            }
            else
            {
                return new NullDiscountStrategy();
            }
        }
    }
}
