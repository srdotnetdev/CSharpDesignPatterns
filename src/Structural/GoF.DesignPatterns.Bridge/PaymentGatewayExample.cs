namespace GoF.DesignPatterns.Bridge;

public interface IPaymentGateway
{
    bool ProcessPayment(double amount);
}

public class PayPalGateway: IPaymentGateway
{
    public bool ProcessPayment(double amount)
    {
        Console.WriteLine($"PayPal Payment Gateway processing amount: ${amount}");
        return true;
    }
}

public class AppleGateway: IPaymentGateway
{
    public bool ProcessPayment(double amount)
    {
        Console.WriteLine($"Apple Payment Gateway processing amount: ${amount}");
        return true;
    }
}

public abstract class OrderProcessor(IPaymentGateway gateway)
{
    protected readonly IPaymentGateway Gateway = gateway;
    
    public abstract void PlaceOrder(double amount);
}

public class OnlineStore(string orderId, IPaymentGateway gateway) : OrderProcessor(gateway)
{
    private readonly string _orderId = orderId;
    
    public override void PlaceOrder(double amount)
    {
        Console.WriteLine($"Processing order {_orderId} for ${amount}");
        
        var isSuccess = Gateway.ProcessPayment(amount);

        Console.WriteLine(!isSuccess
            ? $"Failed to process order {_orderId} for ${amount}"
            : $"Successfully processed order {_orderId} for ${amount}");
        
        Console.WriteLine();
    }
}