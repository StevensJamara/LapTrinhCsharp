using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 14, 3, 4, 19, 6, 7, 8, 9, 10, 20, 13, 39, 52, 99, 66, 74, 81, 73 };
        var sortedNumbers = numbers.OrderBy(n => n).ThenByDescending(n => n % 2 == 0);
        foreach (var number in sortedNumbers)
        {
            System.Console.Write($"{number} ");
        }

    }
}
