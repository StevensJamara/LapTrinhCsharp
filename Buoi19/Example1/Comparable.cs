namespace Example1;

public class ComparableCircle : Circle, IComparable<ComparableCircle>
{
    public ComparableCircle() { }

    public ComparableCircle(double radius) : base(radius) { }

    public ComparableCircle(string color, bool isFilled, double radius) : base(color, isFilled, radius) { }

    public int CompareTo(ComparableCircle? other)
    {
        if (GetRadius() > other?.GetRadius())
        {
            return 1;
        }
        else if (GetRadius() < other?.GetRadius())
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}

