using SalesSystem.Payment.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Core.Payments
{
    internal class VisaPaymentMethod : IPaymentMethod
    {
        public Payment Charge(int customerId, double amount)
        {
            var Commision = amount <= 10000 ? (amount * 0.02) : 0;

            return new Payment
            {
                CustomerId = customerId,
                ChargeAmount = amount + Commision,
                ReferenceNumber = Guid.NewGuid()
            };

        }
    }
}
