namespace ExampleAbstract;

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius, string name) : base(name)
    {
        Radius = radius;
    }

    public Circle(int id, double radius, string name) : base(id, name)
    {
        Radius = radius;
    }

    public abstract void CalculateArea();
}
