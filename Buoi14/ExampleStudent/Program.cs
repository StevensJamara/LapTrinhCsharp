using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var Students = new List<ExampleStudent.Student>
        {
            new ExampleStudent.Student("Alice", 20, "A"),
            new ExampleStudent.Student("Bob", 22, "B"),
            new ExampleStudent.Student("Charlie", 21, "C"),
            new ExampleStudent.Student("David", 23, "A"),
            new ExampleStudent.Student("Eve", 20, "B"),
            new ExampleStudent.Student("Frank", 22, "C"),
            new ExampleStudent.Student("Grace", 21, "A"),
            new ExampleStudent.Student("Hannah", 23, "B"),
            new ExampleStudent.Student("Ian", 20, "C"),
            new ExampleStudent.Student("Jack", 22, "A")
        };

        var group = Students.GroupBy(s =>
        {
            if (s.Grade == "A")
                return "Excellent";
            else if (s.Grade == "B")
                return "Good";
            else
                return "Average";
        });

        foreach (var g in group)
        {
            System.Console.WriteLine($"Grade Group: {g.Key}");
            foreach (var student in g)
            {
                System.Console.WriteLine($" - {student.Name}, Age: {student.Age}");
            }
        }
    }
}