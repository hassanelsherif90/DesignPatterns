namespace OnLineOrders.Core
{
    internal enum OrderState
    {
        Draft,
        Confirmed,
        Canceled,
        UnderProcessing,
        Shipped,
        Delivered,
        Returned
    }
}