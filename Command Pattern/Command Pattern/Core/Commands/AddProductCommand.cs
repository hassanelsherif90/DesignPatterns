using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Core.Commands
{
    internal class AddProductCommand : ICommand
    {
        private readonly Order order;
        private readonly Product product;
        private readonly double quantity;

        public AddProductCommand(Order order, Product product, double quantity)
        {
            this.order = order;
            this.product = product;
            this.quantity = quantity;
        }
        public void Execute()
        {
            order.AddProduct(product, quantity);
        }
    }
}
