namespace GoF.DesignPatterns.Builder;

internal static class Program
{
    private static void Main(string[] args)
    {
        // Basic Builder
        IHouseBuilder builder = new ConcreteHouseBuilder();
        var engineer = new CivilEngineer(builder);
        engineer.ConstructHouse();
        var house = engineer.GetHouse();
        Console.WriteLine(house);
        
        // Fluent Builder
        var car = new CarBuilder()
            .WithMake("Honda")
            .WithModel("Accord")
            .WithColor("White")
            .WithYear(2024)
            .WithEngineSize(1500)
            .Build();
        
        Console.WriteLine(car.ToString());
    }
}