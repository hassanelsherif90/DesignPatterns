using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Core
{
    internal class OrderLines
    {
        public int ProductId { get; internal set; }
        public double UnitPrice { get; internal set; }
        public double Quantity { get; internal set; }
    }
}
