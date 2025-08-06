namespace ExampleAbstract;

public abstract class Shape
{
    public string Name { get; set; }
    int id;
    protected Shape(string name)
    {
        this.Name = name;
    }
    protected Shape(int id, string name)
    {
        this.id = id;
        this.Name = name;
    }
}
