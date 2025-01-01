namespace GoF.DesignPatterns.Builder;

public class House
{
    public string? Foundation { get; set; }
    public string? Floor { get; set; }
    public string? Structure { get; set; }
    public string? Roof { get; set; }
    public string? Interior { get; set; }

    public override string ToString()
    {
        return $"House with {Foundation}, {Floor}, {Structure}, {Roof} & {Interior}";
    }
}

public interface IHouseBuilder
{
    void BuildFoundation();
    void BuildFloor();
    void BuildStructure();
    void BuildRoof();
    void BuildInterior();
    House Build();
}

public class ConcreteHouseBuilder : IHouseBuilder
{
    private readonly House _house = new House();
    
    public void BuildFoundation()
    {
        _house.Foundation = "Concrete Foundation";
    }

    public void BuildFloor()
    {
        _house.Floor = "Concrete Floor";
    }

    public void BuildStructure()
    {
        _house.Structure = "Concrete Structure";
    }

    public void BuildRoof()
    {
        _house.Roof = "Concrete Roof";
    }

    public void BuildInterior()
    {
        _house.Interior = "Concrete Interior";
    }

    public House Build()
    {
        return _house;
    }
}

public class CivilEngineer(IHouseBuilder houseBuilder)
{
    private readonly IHouseBuilder _houseBuilder = houseBuilder;

    public void ConstructHouse()
    {
        _houseBuilder.BuildFoundation();
        _houseBuilder.BuildFloor();
        _houseBuilder.BuildStructure();
        _houseBuilder.BuildRoof();
        _houseBuilder.BuildInterior();
    }

    public House GetHouse()
    {
        return _houseBuilder.Build();
    }
}
