using SalesSystem.Payment.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Core.Payments
{
    internal class PayPalPaymentProcessor : PaymentProcessor
    {
        public override IPaymentMethod CreatePaymentMethod()
        {
           return new PayPalPaymentMethod();    
        }
    }
}
