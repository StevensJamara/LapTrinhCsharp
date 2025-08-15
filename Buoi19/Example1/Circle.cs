namespace Example1;

public class Circle : Shape
{
    private double Radius;
    public Circle() { }
    public Circle(double radius)
    {
        this.Radius = radius;
    }
    public Circle(string color, bool isFilled, double radius) : base(color, isFilled)
    {
        this.Radius = radius;
    }
    public double GetRadius()
    {
        return this.Radius;
    }
    public void SetRadius(double radius)
    {
        this.Radius = radius;
    }
    public double GetArea()
    {
        return Math.PI * this.Radius * this.Radius;
    }
    public double GetPerimeter()
    {
        return 2 * Math.PI * this.Radius;
    }
}
