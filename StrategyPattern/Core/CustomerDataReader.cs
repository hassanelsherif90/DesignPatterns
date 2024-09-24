using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Core
{
    public class CustomerDataReader
    {
        public IEnumerable <Customer> GetCustomer()
        {
            return new[]
            {
                new Customer
                {
                    Id = 1,
                    Name = "Hassan Ali Mohamed",
                    Category = CustomerCategory.Gold
                }, 
                new Customer
                {
                    Id = 2,
                    Name = "Mohamed Ali Mohamed",
                     Category = CustomerCategory.Silver
                }
            };
        }
    }
}
