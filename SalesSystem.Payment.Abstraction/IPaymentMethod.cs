using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Payment.Abstraction
{
    public interface IPaymentMethod
    {
        Payment Charge(int customerId, double amount ); 
    }
}
