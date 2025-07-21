public class Program
{
    public static void Main(string[] args)
    {
        // Create an array of integers
        int[] numbers = { 14, 26, 3, 4, 5, 6, 8, 9, 10, 30, 20, 15, 25, 35 };
        int minValue = numbers[0];

        // Print the elements of the array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Element at index {i}: {numbers[i]}");
            // Check if the current element is less than the current minimum value
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
            }
            Console.WriteLine($"Minimum value index {i} in the array: {minValue}");
        }
        
    }
}
