namespace GoF.DesignPatterns.Bridge;

internal static class Program
{
    private static void Main(string[] args)
    {
        // Payment Gateway Example
        OrderProcessor payPalOrderProcessor = new OnlineStore("ORD123456", new PayPalGateway());
        OrderProcessor appleOrderProcessor = new OnlineStore("APP123456", new AppleGateway());
        payPalOrderProcessor.PlaceOrder(100.00);
        appleOrderProcessor.PlaceOrder(200.00);
    }
}