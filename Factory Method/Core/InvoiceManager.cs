using StrategyPattern.Core.CustomerDiscountStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Core
{
    internal class InvoiceManager
    {
        private ICustomerDiscountStrategy _customerDiscountStrategy;
        public void SetDiscountStrategy(ICustomerDiscountStrategy Strategy)
        {
            _customerDiscountStrategy = Strategy;
        }
        public Invoice CreateInvoice(Customer customer, double quantity, double unitPrice)
        {
           

            var invoice = new Invoice
            {
                Customer = customer,
                Lines = new[]
                {
                    new InvoiceLines { Quantity = quantity, UnitPrice = unitPrice }
                }

            };

            invoice.DiscountPersentag = _customerDiscountStrategy.CalculateDiscount(invoice.TotalPrice);

            return invoice;
        }
    }
}
