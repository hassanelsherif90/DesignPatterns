using FactoryMethod.Core.Payments;
using SalesSystem.Payment.Abstraction;
using SimpleFactory;
using StrategyPattern.Core;
using StrategyPattern.Core.CustomerDiscountStrategy;
using TemplateMethod.Core;
using TemplateMethod.Core.ShopingCarts;

var dataReader = new CustomerDataReader();
var customers = dataReader.GetCustomer();
var items = new ItemsDataReader().GetItem();

while (true)
{
    Console.WriteLine("Customer List : ");
    foreach (var customer in customers)
    {
        Console.WriteLine($"\t[{customer.Id}] : {customer.Name} ({customer.Category}) ");
    }

    Console.WriteLine("Item List : ");
    foreach (var item in items)
    {
        Console.WriteLine($"\t[{item.Id}] : {item.Name} ({item.UnitPrice:0.00}) ");
    }
    Console.WriteLine();

    Console.Write($"Enter Customer ID: ");
    var customerId = int.Parse( Console.ReadLine() );

    Console.Write("Select Shopping Cart Type (Online | InStore): ");
    ShopingCarts shoppingCart = Console.ReadLine().Equals("Online", StringComparison.OrdinalIgnoreCase)? new OnLineShopingCarts() : new InStoreShopingCarts();

    while (true)
    {
        Console.Write("Enter Item ID (0 to Comlete the order): ");
        var itemId = int.Parse(Console.ReadLine()); ;

        if (itemId == 0)
            break;

        Console.Write($"Enter Item Quantity: ");
        var quantity = double.Parse(Console.ReadLine());

        var item = items.First(x => x.Id == itemId);
        shoppingCart.AddItem(itemId, item.UnitPrice, quantity);
    }
    
    //Console.WriteLine($"Enter Unit Price: ");
    // var unitPrice = double.Parse( Console.ReadLine() );
   
    var Selectedcustomer = customers.First(x => x.Id == customerId);

    // var invoiceManager = new InvoiceManager();
    // ICustomerDiscountStrategy customerDiscountStrategy = new CustomerDiscountStrategyFactory().CreateCustomerDiscountStrategyFactory(Selectedcustomer.Category);
    // invoiceManager.SetDiscountStrategy(customerDiscountStrategy);

    // var invoice = invoiceManager.CreateInvoice(Selectedcustomer, quantity, unitPrice);  
    // Console.WriteLine($"Invoice created for customer '{Selectedcustomer.Name}' with total price: {invoice.NetPrice}");

    Console.Write("Select Payment Method (PayPal | Visa) : ");
    PaymentProcessor paymentProcessor = Console.ReadLine() == "Visa" ?  new VisaPaymentProcessor():new PayPalPaymentProcessor();    

    shoppingCart.CheckOut(Selectedcustomer, paymentProcessor);
    Console.WriteLine("Press any key to create another invoice ");
    Console.WriteLine("------------------------------------------");
    
    

}