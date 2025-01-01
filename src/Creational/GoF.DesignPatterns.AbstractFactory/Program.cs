namespace GoF.DesignPatterns.AbstractFactory;

public static class Program
{
    private static void Main(string[] args)
    {
        // Abstract Device Factory
        var appleFactory = new AppleFactory();
        var applePhone = appleFactory.CreatePhone();
        applePhone.GetDetails();
        var appleLaptop = appleFactory.CreateLaptop();
        appleLaptop.GetDetails();
        
        var samsungFactory = new SamsungFactory();
        var samsungPhone = samsungFactory.CreatePhone();
        samsungPhone.GetDetails();
        var samsungLaptop = samsungFactory.CreateLaptop();
        samsungLaptop.GetDetails();
    }
}