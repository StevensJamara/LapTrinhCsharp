namespace ExampleInheritance;

public class Cone : Circle
{
    public double Height { get; set; }

    public Cone(double radius, double height) : base(radius)
    {
        Height = height;
    }

    public double CalculateVolume()
    {
        return (1.0 / 3) * CalculateArea() * Height;
    }

    public override void CalculateArea()
    {
        // Implement the area calculation for the cone
        double baseArea = Math.PI * Radius * Radius;
        double slantHeight = Math.Sqrt(Radius * Radius + Height * Height);
        double lateralArea = Math.PI * Radius * slantHeight;
        double totalArea = baseArea + lateralArea;
        Console.WriteLine($"Cone Area: {totalArea}");
    }
}
