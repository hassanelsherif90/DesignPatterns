using Command_Pattern.Core;
using Command_Pattern.Core.Commands;

var laptop = new Product(1, "laptop", 20000, 10);
var keybord = new Product(2, "keybord", 300, 50);
var mouse = new Product(3, "mouse", 150, 70);

while (true)
{
    var order = new Order();
    var invoker = new CommandInvoker();

    while (true)
    {
        Console.WriteLine("Select one of the below commands:");
        Console.WriteLine("\t1. Add Laptop");
        Console.WriteLine("\t2. Add Keybord");
        Console.WriteLine("\t3. Add Mouse");
        Console.WriteLine("\t4. Save Macro");
        Console.WriteLine("\t5. Replay Macro");
        Console.WriteLine("\t0. Process & Exit");

        var commandId = int.Parse(Console.ReadLine());
        //Product selectProduct = null;

        switch (commandId)
        {
            case 1:
                invoker.AddCommand(new AddProductCommand(order, laptop, 1));
                invoker.AddCommand(new AddStockCommand(laptop, -1));
                break;
            case 2:
                invoker.AddCommand(new AddProductCommand(order, keybord, 1));
                invoker.AddCommand(new AddStockCommand(keybord, -1));
                break;
            case 3:
                invoker.AddCommand(new AddProductCommand(order, mouse, 1));
                invoker.AddCommand(new AddStockCommand(mouse, -1));
                break;
            case 4:
                MacroStorage.Instance.CreateMacro(invoker.GetCommands());
                invoker.ClearCommands();
                break;
            case 5:
                ReplayMacro();
                break;

            case 0:
                {
                    invoker.ExecuteCommands();
                    var totalQuantity = order.Lines.Sum(x => x.Quantity);
                    var totalPrice = order.Lines.Sum(x => x.Quantity * x.UnitPrice);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Order #{order.Id} created: Quantity = {totalQuantity}, Total Price = {totalPrice}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                break;
        }

        //order.AddProduct(selectProduct, 1);
        //selectProduct.AddStock(-1);
    }

    Console.WriteLine("------------------------------------------------------------");
}

void ReplayMacro()
{
    Console.WriteLine("Enter Macro ID:");

    foreach(var macro in MacroStorage.Instance.GetMacros())
    {
        Console.WriteLine($"\t{macro.Id}. (Commands Count: {macro.Commands.Count()} , Created At: {macro.CreatedAt:yyyy-MM-dd HH:mm:ss})");

    }

    var macroId=int.Parse(Console.ReadLine());
    var selectedMacro = MacroStorage.Instance.GetMacro(macroId);

    var order = new Order();
    var invoker = new CommandInvoker();

    foreach (var command in selectedMacro.Commands)
    {
        if (command is AddProductCommand addProductCommand)
        {
            addProductCommand.Order = order;
        }
        invoker.AddCommand(command);
    }
    invoker.ExecuteCommands();

}