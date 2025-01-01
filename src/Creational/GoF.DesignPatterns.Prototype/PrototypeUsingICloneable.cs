namespace GoF.DesignPatterns.Prototype;

public interface IShape : ICloneable
{
    void Draw();
}

public class Circle(int radius) : IShape
{
    private readonly int _radius = radius;
    
    public object Clone()
    {
        return this.MemberwiseClone(); // Shallow Copy
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing Circle with radius: {_radius}");
    }
}

public class Rectangle(int height, int width) : IShape
{
    private readonly int _height = height;
    private readonly int _width = width;
    
    public object Clone()
    {
        return this.MemberwiseClone(); // Shallow Copy
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing Rectangle with height = {_height} & width = {_width}");
    }
}