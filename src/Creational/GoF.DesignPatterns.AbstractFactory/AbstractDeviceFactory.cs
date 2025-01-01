namespace GoF.DesignPatterns.AbstractFactory;

public interface IDevice
{
    void GetDetails();
}

public class ApplePhone : IDevice
{
    public void GetDetails()
    {
        Console.WriteLine("I am Apple phone");
    }
}

public class AppleLaptop : IDevice
{
    public void GetDetails()
    {
        Console.WriteLine("I am Apple laptop");
    }
}

public class SamsungPhone : IDevice
{
    public void GetDetails()
    {
        Console.WriteLine("I am Samsung phone");
    }
}

public class SamsungLaptop : IDevice
{
    public void GetDetails()
    {
        Console.WriteLine("I am Samsung laptop");
    }
}

public interface IDeviceFactory
{
    IDevice CreatePhone();
    IDevice CreateLaptop();
}

public class AppleFactory : IDeviceFactory
{
    public IDevice CreatePhone()
    {
        return new ApplePhone();
    }

    public IDevice CreateLaptop()
    {
        return new AppleLaptop();
    }
}

public class SamsungFactory : IDeviceFactory
{
    public IDevice CreatePhone()
    {
        return new SamsungPhone();
    }

    public IDevice CreateLaptop()
    {
        return new SamsungLaptop();
    }
}