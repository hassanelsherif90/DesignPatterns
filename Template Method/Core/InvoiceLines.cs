using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Core
{
    internal class InvoiceLines
    {
        public int ItemId { get; set; }
        public double Quantity { get;  set; }
        public double UnitPrice { get;  set; }
    }
}
