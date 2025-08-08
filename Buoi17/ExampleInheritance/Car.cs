namespace ExampleInheritance;

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public int Seats { get; set; }

    public Car(string name, int numberOfDoors, int seats) : base(name)
    {
        this.NumberOfDoors = numberOfDoors;
        this.Seats = seats;
    }

    public Car(int id, string name, int numberOfDoors, int seats) : base(id, name)
    {
        this.NumberOfDoors = numberOfDoors;
        this.Seats = seats;
    }

    public void DisplayCarInfo()
    {
        Console.WriteLine($"Car Name: {Name}, ID: {Id}, Speed: {Speed} km/h, Doors: {NumberOfDoors}, Seats: {Seats}");
    }
    public override void StartEngine()
    {
        Console.WriteLine($"{Name} car engine started.");
    }
}