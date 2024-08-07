using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Core;

namespace TemplateMethod.Core.ShopingCarts
{
    internal class InStoreShopingCarts : ShopingCarts
    {
        protected override void ApplyDisCount(Invoice invoice)
        {
            
        }
    }
}
