namespace ExamAbstract;

public class Human
{
    public string Name { get; set; }
    public int Age { get; set; }

    public float Height { get; set; }
    public Human()
    {
        Name = "Unknown";
        Age = 0;
        Height = 0.0f;
    }
    public Human(string name, int age, float height)
    {
        Name = name;
        Age = age;
        Height = height;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Height: {Height}");
    }
}
