// ReSharper disable ConvertConstructorToMemberInitializers
// ReSharper disable FieldCanBeMadeReadOnly.Local
namespace GoF.DesignPatterns.Builder;

public class Car
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public string? Color { get; set; }
    public int EngineSize { get; set; }

    public override string ToString()
    {
        return $"Make: {Make}, Model: {Model}, Year: {Year}, Color: {Color}, EngineSize: {EngineSize}";
    }
}

public class CarBuilder
{
    private Car _car;

    public CarBuilder()
    {
        _car = new Car();
    }

    public CarBuilder WithMake(string make)
    {
        _car.Make = make;
        return this;
    }

    public CarBuilder WithModel(string model)
    {
        _car.Model = model;
        return this;
    }

    public CarBuilder WithYear(int year)
    {
        _car.Year = year;
        return this;
    }

    public CarBuilder WithColor(string color)
    {
        _car.Color = color;
        return this;
    }

    public CarBuilder WithEngineSize(int engineSize)
    {
        _car.EngineSize = engineSize;
        return this;
    }

    public Car Build()
    {
        return _car;
    }
}