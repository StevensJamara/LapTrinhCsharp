using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Using LINQ to filter even numbers
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        var hasEvenNumbers = evenNumbers.Any(n => n % 2 == 0);
        // Displaying the even numbers
        foreach (var number in evenNumbers)
        {
            System.Console.WriteLine(number);
        }
    }
}
