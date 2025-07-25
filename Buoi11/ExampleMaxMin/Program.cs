public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        // Input a 2D array
        int[,] matrix = Input2DArray(rows, cols);

        // Display the elements of the 2D array
        Console.WriteLine("Elements of the 2D array:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Find and display the maximum and minimum values in the array
        (int max, int min) = FindMaxMinInArray(matrix);
        Console.WriteLine($"Maximum value in the array: {max}");
        Console.WriteLine($"Minimum value in the array: {min}");
    }

    public static int[,] Input2DArray(int rows, int cols)
    {
        int[,] array = new int[rows, cols];
        Random rand = new Random();
        Console.WriteLine("Generating random elements of the 2D array (1-100):");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = rand.Next(1, 101); // 1 to 100 inclusive
                Console.WriteLine($"Element [{i},{j}]: {array[i, j]}");
            }
        }
        return array;
    }

    public static (int max, int min) FindMaxMinInArray(int[,] array)
    {
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                }
                if (array[i, j] < min)
                {
                    min = array[i, j];
                }
            }
        }

        return (max, min);
    }
}
