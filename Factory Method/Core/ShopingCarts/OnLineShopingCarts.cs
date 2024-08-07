using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Core;

namespace TemplateMethod.Core.ShopingCarts
{
    internal class OnLineShopingCarts : ShopingCarts
    {
        protected override void ApplyDisCount(Invoice invoice)
        {
            if(invoice.TotalPrice >= 10000)
            {
                invoice.DiscountPersentag = 0.05;
            }
        }
    }
}
