namespace GoF.DesignPatterns.Prototype;

internal static class Program
{
    private static void Main(string[] args)
    {
        // Using ICloneable
        var circle1 = new Circle(10);
        circle1.Draw();
        
        var circle2 = (Circle)circle1.Clone();
        circle2?.Draw();

        Console.WriteLine($"Are both circles equal? {circle1?.Equals(circle2)}");
        
        // Using IPrototype<T>
        var gameCharacter = new GameCharacter {Name = "Bob", Health = 100, Level = 2, AttackPower = 80};
        var clonedGameCharacter = gameCharacter.Clone();
        clonedGameCharacter.Name = "John";

        Console.WriteLine(gameCharacter);
        Console.WriteLine(clonedGameCharacter);

    }
}