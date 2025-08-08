using ExampleInheritance;

public class Program
{
    public static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle("Generic Vehicle");
        vehicle.DisplayInfo();
        vehicle.StartEngine();

        Car car = new Car("Sedan", 4, 5);
        car.DisplayCarInfo();
        car.StartEngine();
    }
}
