public class Program
{
    public static void Main(string[] args)
    {
        Student[] students = {
            new Student { Name = "Alice", Age = 20, Score = 85.5f },
            new Student { Name = "Bob", Age = 22, Score = 90.0f },
            new Student { Name = "Charlie", Age = 21, Score = 78.0f }
        };

        foreach (var student in students)
        {
            System.Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Score: {student.Score}");
        }
    }
}
