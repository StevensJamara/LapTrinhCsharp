public class Program
{
    public static void Main(string[] args)
    {
        // Declare and initialize a 2D array
        int[,] numbers = new int[3, 4]
        {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

        // Print the elements of the 2D array
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write(numbers[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Column in the array: " + numbers.GetLength(0));
        Console.WriteLine("Row in the array: " + numbers.GetLength(1));
        Console.WriteLine("Total elements in the array: " + numbers.Length);
    }
}
