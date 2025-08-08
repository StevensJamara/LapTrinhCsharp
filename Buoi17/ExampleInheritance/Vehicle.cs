namespace ExampleInheritance;

public class Vehicle
{
    public string Name { get; set; }
    public int Id { get; set; }
    public float Speed { get; set; }
    public Vehicle(string name)
    {
        this.Name = name;
    }

    public Vehicle(int id, string name)
    {
        this.Id = id;
        this.Name = name;
        this.Speed = 0.0f; // Default speed
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Vehicle Name: {Name}, ID: {Id}, Speed: {Speed} km/h");
    }
    public virtual void StartEngine()
    {
        Console.WriteLine($"{Name} engine started.");
    }
}
