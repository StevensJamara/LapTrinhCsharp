namespace Example1;

public class Shape
{
    private string Color = "Green";
    private bool IsFilled = true;
    public Shape()
    {

    }
    public Shape(string color, bool isFilled)
    {
        this.Color = color;
        this.IsFilled = isFilled;
    }
    public string GetColor()
    {
        return this.Color;
    }
    public bool GetIsFilled()
    {
        return this.IsFilled;
    }
    public void SetColor(string color)
    {
        this.Color = color;
    }
    public void SetIsFilled(bool isFilled)
    {
        this.IsFilled = isFilled;
    }
    public override string ToString()
    {
        return $"Shape[Color={this.Color}, IsFilled={this.IsFilled}]";
    }
}
