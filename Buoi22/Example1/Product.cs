namespace Example1;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    override public string ToString()
    {
        return $"{Name} - {Price:C}";
    }
}
