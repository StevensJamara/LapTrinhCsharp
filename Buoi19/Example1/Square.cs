namespace Example1;

public class Square : Rectangle
{
    public Square() { }
    public Square(double side) : base(side, side)
    {

    }
    public Square(string color, bool isFilled, double sideLength) : base(color, isFilled, sideLength, sideLength)
    {
        base.Height = sideLength;
        base.Width = sideLength;
    }
    public double GetSide()
    {
        return base.Height; // or base.Width, since they are equal
    }
    public void SetSide(double side)
    {
        base.Height = side;
        base.Width = side;
    }
    public override string ToString()
    {
        return $"Square[Color={GetColor()}, IsFilled={GetIsFilled()}, Side={GetSide()}]";
    }
}
