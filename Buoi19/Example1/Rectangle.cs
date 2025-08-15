namespace Example1;

public class Rectangle : Shape
{
    public double Height;
    public double Width;
    public Rectangle() { }
    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }
    public Rectangle(string color, bool isFilled, double height, double width) : base(color, isFilled)
    {
        this.Height = height;
        this.Width = width;
    }
    public double GetHeight()
    {
        return this.Height;
    }
    public virtual void SetHeight(double height)
    {
        this.Height = height;
    }
    public double GetWidth()
    {
        return this.Width;
    }
    public virtual void SetWidth(double width)
    {
        this.Width = width;
    }
    public double GetArea()
    {
        return this.Height * this.Width;
    }
    public double GetPerimeter()
    {
        return 2 * (this.Height + this.Width);
    }
}
