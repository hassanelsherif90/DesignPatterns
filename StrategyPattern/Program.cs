using StrategyPattern.Core;
using StrategyPattern.Core.CustomerDiscountStrategy;

CustomerDataReader? dataReader = new CustomerDataReader();
IEnumerable<Customer>? customers = dataReader.GetCustomer();

while(true)
{
    Console.WriteLine("Customer List : [1] Hassan Ali Mohamed  [2] Mohamed Ali Mohamed");

    Console.Write($"Enter Customer ID: ");
    int customerId = int.Parse( Console.ReadLine()); 

    Console.Write($"Enter Item Quantity: ");
    double quantity = double.Parse( Console.ReadLine() ); 

    Console.Write($"Enter Unit Price: ");
    double unitPrice = double.Parse( Console.ReadLine() );

    Customer? customer = customers.First(x => x.Id == customerId);

    ICustomerDiscountStrategy customerDiscountStrategy = null;

    if(customer.Category == CustomerCategory.Gold )
    {
        customerDiscountStrategy = new GoldCustomerDiscountStrategy();
    }
    else if(customer.Category == CustomerCategory.Silver)
    {
        customerDiscountStrategy = new SilverCustomerDiscountStrategy();
    }else
    {
        customerDiscountStrategy = new NewCustomerDiscountStrategy();

    }
   

    InvoiceManager? invoiceManager = new InvoiceManager();
    invoiceManager.SetDiscountStrategy(customerDiscountStrategy!);

    Invoice? invoice = invoiceManager.CreateInvoice(customer, quantity, unitPrice); 
    
    Console.WriteLine($"Invoice created for customer '{customer.Name}' with total price: {invoice.NetPrice}");
    Console.WriteLine("Press any key to create another invoice ");
    Console.WriteLine("------------------------------------------");
    
    

}