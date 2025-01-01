namespace GoF.DesignPatterns.FactoryMethod;

public interface INotification
{
    void Notify(string message);
}

public class EmailNotification : INotification
{
    public void Notify(string message)
    {
        Console.WriteLine($"Email notification: {message}");
    }
}

public class SmsNotification : INotification
{
    public void Notify(string message)
    {
        Console.WriteLine($"Sms notification: {message}");
    }
}

public class NotificationFactory
{
    public static INotification CreateNotification(string type)
    {
        return type.ToLower() switch
        {
            "email" => new EmailNotification(),
            "sms" => new SmsNotification(),
            _ => throw new ArgumentException("Invalid notification type")
        };
    }
}