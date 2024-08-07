using SalesSystem.Payment.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Core.Payments
{
    internal class PayPalPaymentMethod : IPaymentMethod
    {
        public Payment Charge(int customerId, double amount)
        {
            return new Payment
            {
                CustomerId = customerId,
                ChargeAmount = amount + amount * 0.05,
                ReferenceNumber = Guid.NewGuid()
            };
        }
    }
}
