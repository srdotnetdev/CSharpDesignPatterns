namespace GoF.DesignPatterns.FactoryMethod;

internal static class Program
{
    private static void Main(string[] args)
    {
        // Basic Factory Method
        ShapeFactory circleFactory = new CircleFactory();
        var circle = circleFactory.CreateShape();
        circle.Draw();
        
        ShapeFactory rectangleFactory = new RectangleFactory();
        var rectangle = rectangleFactory.CreateShape();
        rectangle.Draw();
        
        // Parameterized Factory Method
        var emailNotification = NotificationFactory.CreateNotification("email");
        emailNotification.Notify("This is a message for notification");
        
        var smsNotification = NotificationFactory.CreateNotification("sms");
        smsNotification.Notify("This is a message for notification");
        
        // Factory Method With Dependency Injection
        var carService = new VehicleService(new CarFactory());
        carService.StartJourney();
        
        var truckService = new VehicleService(new TruckFactory());
        truckService.StartJourney();
    }
}