namespace ExampleInheritance;

public class Clylinder : Circle
{
    public double Height { get; set; }

    public Cylinder(double radius, double height) : base(radius)
    {
        Height = height;
    }

    public double CalculateVolume()
    {
        return CalculateArea() * Height;
    }
    public override void CalculateArea()
    {
        // Implement the area calculation for the cylinder
        double baseArea = Math.PI * Radius * Radius;
        double lateralArea = 2 * Math.PI * Radius * Height;
        double totalArea = 2 * baseArea + lateralArea;
        Console.WriteLine($"Cylinder Area: {totalArea}");
    }
}
