using SimpleFactory;
using StrategyPattern.Core;
using StrategyPattern.Core.CustomerDiscountStrategy;

var dataReader = new CustomerDataReader();
var customers = dataReader.GetCustomer();

while(true)
{
    Console.WriteLine("Customer List : [1] Hassan Ali Mohamed  [2] Mohamed Ali Mohamed");
    Console.WriteLine($"Enter Customer ID: ");
    var customerId = int.Parse( Console.ReadLine() ); 
    Console.WriteLine($"Enter Item Quantity: ");
    var quantity = double.Parse( Console.ReadLine() ); 
    Console.WriteLine($"Enter Unit Price: ");
    var unitPrice = double.Parse( Console.ReadLine() );
   
    
    var customer = customers.First(x => x.Id == customerId);
    var invoiceManager = new InvoiceManager();
    ICustomerDiscountStrategy customerDiscountStrategy = new CustomerDiscountStrategyFactory().CreateCustomerDiscountStrategyFactory(customer.Category);
    invoiceManager.SetDiscountStrategy(customerDiscountStrategy);
    
    var invoice = invoiceManager.CreateInvoice(customer, quantity, unitPrice);  
    Console.WriteLine($"Invoice created for customer '{customer.Name}' with total price: {invoice.NetPrice}");
    Console.WriteLine("Press any key to create another invoice ");
    Console.WriteLine("------------------------------------------");
    
    

}