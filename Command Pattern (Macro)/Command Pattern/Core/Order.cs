using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Command_Pattern.Core
{
    internal class Order
    {
        public int Id { get; } = Random.Shared.Next(1, 100);
        private List<OrderLines> _lines { get; } = new();

        public IEnumerable<OrderLines> Lines => _lines.AsReadOnly();

        public void AddProduct(Product product, double quantity)
        {
            _lines.Add(new OrderLines { ProductId = product.Id, UnitPrice = product.UnitPrice, Quantity = quantity });

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Product '{product.Name}' added , Order now contains {_lines.Count}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
