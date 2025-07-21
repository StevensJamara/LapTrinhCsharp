public class Program
{
    public static void Main(string[] args)
    {
        // Create an array of integers
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;
        // Print the elements of the array
        foreach (int number in numbers)
        {
            sum = numbers[number - 1] += 1; // Increment each number by 1
        }

        Console.Write($"Array sum: {sum}");
    }
}
