public class Human
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public Human() { }
    public Human(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}

public class Staff : Human
{
    public string? Position { get; set; }
    public Staff() { }
    public Staff(string name, int age, string position) : base(name, age)
    {
        this.Position = position;
    }
}

public class Student : Human
{
    public string? Major { get; set; }
    public Student() { }
    public Student(string name, int age, string major) : base(name, age)
    {
        this.Major = major;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Example usage of Human, Staff, and Student classes
        Human[] humans = {
            new Human { Name = "Alice", Age = 30 },
            new Human { Name = "Bob", Age = 25 },
            new Human { Name = "Charlie", Age = 35 }
        };
        Staff[] staffMembers = {
            new Staff { Name = "David", Age = 40, Position = "Manager" },
            new Staff { Name = "Eve", Age = 28, Position = "Developer" }
        };
        Student[] students = {
            new Student { Name = "Frank", Age = 22, Major = "Computer Science" },
            new Student { Name = "Grace", Age = 21, Major = "Mathematics" }
        };

        // Sorting and displaying the collections
        var sortedHumans = humans.OrderBy(h => h.Age).ThenBy(h => h.Name);
        foreach (var human in sortedHumans)
        {
            System.Console.WriteLine($"{human.Name}, {human.Age}");
        }
        var sortedStaff = staffMembers.OrderBy(s => s.Age).ThenBy(s => s.Name);
        foreach (var staff in sortedStaff)
        {
            System.Console.WriteLine($"{staff.Name}, {staff.Age}, {staff.Position}");
        }
        var sortedStudents = students.OrderBy(s => s.Age).ThenBy(s => s.Name);
        foreach (var student in sortedStudents)
        {
            System.Console.WriteLine($"{student.Name}, {student.Age}, {student.Major}");
        }
    }
}