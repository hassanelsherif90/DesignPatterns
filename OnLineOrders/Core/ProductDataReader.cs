using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineOrders.Core
{
    internal class ProductDataReader
    {
        public IEnumerable<Product> GetProducts()
        { 
            return new []
            {
                new Product{ Id = 1, Name = "LapTop", UnitPrice = 10000},
                new Product{ Id = 2, Name = "LCD", UnitPrice = 2000},
                new Product{ Id = 3, Name = "Keypoard", UnitPrice = 150},
                new Product{ Id = 4, Name = "Mouse", UnitPrice = 100}
            };
        }
    }
}
