// ReSharper disable PropertyCanBeMadeInitOnly.Global
namespace GoF.DesignPatterns.Prototype;

public interface IPrototype<out T>
{
    T Clone();
}

public class GameCharacter : IPrototype<GameCharacter>
{
    public string? Name { get; set; }
    public int Level { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    
    public GameCharacter Clone()
    {
        return (GameCharacter)MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Game Character with (Name: {Name}, Level: {Level}, Health: {Health}, AttachPower: {AttackPower})";
    }
}