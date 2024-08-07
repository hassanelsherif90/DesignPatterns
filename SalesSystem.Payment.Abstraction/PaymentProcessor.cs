using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem.Payment.Abstraction
{
    public abstract class PaymentProcessor
    {
        public Payment ProcessPayment(int customerId, double amount)
        {
            var paymentProcess = CreatePaymentMethod();
            var payment = paymentProcess.Charge(customerId, amount);    
            return payment;
        }

        public abstract IPaymentMethod CreatePaymentMethod();
       
    }
}
