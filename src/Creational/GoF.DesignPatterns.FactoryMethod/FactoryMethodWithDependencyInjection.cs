namespace GoF.DesignPatterns.FactoryMethod;

public interface IVehicle
{
    void Drive();
}

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a car");
    }
}

public class Truck : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a truck");
    }
}

public interface IVehicleFactory
{
    IVehicle CreateVehicle();
}

public class CarFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new Car();
    }
}

public class TruckFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new Truck();
    }
}

public class VehicleService(IVehicleFactory vehicleFactory)
{
    private readonly IVehicleFactory _vehicleFactory = vehicleFactory;

    public void StartJourney()
    {
        var vehicle = _vehicleFactory.CreateVehicle();
        vehicle.Drive();
    }
}