public class Program
{
    public static void Main(string[] args)
    {
        // Create an array of integers
        int[] numbers = { 1, 2, 3, 4, 5 };
        int[] numbers2 = new int[5] { 6, 7, 8, 9, 10 };

        Console.WriteLine($"Array 1: {numbers[1]}");
        // Print the elements of the array
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }
    }
}
