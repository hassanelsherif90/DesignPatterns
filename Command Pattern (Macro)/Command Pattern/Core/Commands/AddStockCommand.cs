using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern.Core.Commands
{
    internal class AddStockCommand : ICommand
    {
        private readonly Product product;
        private readonly double quantity;

        public AddStockCommand(Product product, double quantity) {
            this.product = product;
            this.quantity = quantity;
        }
        public void Execute()
        {
            product.AddStock(quantity);
        }
    }
}
