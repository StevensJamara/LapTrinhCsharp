public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input Length of the array: ");
        int length = int.Parse(Console.ReadLine());

        // Input a 2D array
        int[,] matrix = new int[n, n];

        // Print the elements of the 2D array
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }

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

        // Calculate the sum of all elements in the array
        int sum = 0;
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
        }
        Console.WriteLine("Sum of all elements in the array: " + sum);

        // Calculate the sum of diagonal elements in the array
        int diagonalSum = 0;
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j)
                {
                    diagonalSum += matrix[i, j];
                }
            }
        }
    }
}
