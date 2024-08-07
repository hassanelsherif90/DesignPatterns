using SalesSystem.Payment.Abstraction;
using StrategyPattern.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Core.ShopingCarts
{
    internal abstract class ShopingCarts
    {
        public List<InvoiceLines> _Lines = new();
        public void AddItem(int itemid, double unitPrice, double quintity)
        {
            _Lines.Add(new InvoiceLines {ItemId= itemid, UnitPrice= unitPrice, Quantity = quintity });
        }


        public void CheckOut(Customer customer, PaymentProcessor paymentProcessor)
        {
            var invoice = new Invoice
            {
                Customer = customer,
                Lines = _Lines  
            };

            ApplyTaxes(invoice);
            ApplyDisCount(invoice);
            ProcessPayment(invoice, paymentProcessor);
        }

        
        private void ApplyTaxes(Invoice invoice)
        {
            invoice.Taxes = invoice.TotalPrice * .15;
        }

        protected abstract void ApplyDisCount(Invoice invoice);
        

        private void ProcessPayment(Invoice invoice, PaymentProcessor paymentProcessor)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"({GetType().Name}) Invoice created for customer '{invoice.Customer.Name}' whit net price: {invoice.NetPrice}");

            var payment = paymentProcessor.ProcessPayment(invoice.Customer.Id, invoice.NetPrice);
            Console.WriteLine($"customer charged with  '{payment.ChargeAmount:0.00}' payment ref: {payment.ReferenceNumber}");
            Console.ForegroundColor= ConsoleColor.White;    
        }

    }
}
