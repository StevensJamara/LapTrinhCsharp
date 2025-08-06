namespace ExampleInheritance;

public abstract class Circle
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public abstract void CalculateArea();
}
