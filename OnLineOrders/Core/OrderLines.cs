namespace OnLineOrders.Core
{
    public class OrderLines
    {
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}