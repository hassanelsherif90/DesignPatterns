namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter base currency : ");
                var baseCurrency = Console.ReadLine();  
                Console.WriteLine("Enter target currency : ");
                var targetCurrency = Console.ReadLine(); Console.WriteLine("Enter target currency : ");
                Console.WriteLine("Enter amount : ");
                var amount = decimal.Parse(Console.ReadLine());
                //var conveter = new CurrencyConverter();
                var exchangedAmount = CurrencyConverter.Instance.Convert(baseCurrency, targetCurrency, amount);
                Console.WriteLine($"{amount}  {baseCurrency} = {exchangedAmount} {targetCurrency}");
                Console.WriteLine("-----------------------------------------------------------");

            }
        }
    }
}
