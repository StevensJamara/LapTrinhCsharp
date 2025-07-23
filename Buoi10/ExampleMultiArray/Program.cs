public class Program
{
    public static void Main(string[] args)
    {
        // Declare and initialize a 2D array
        int[,] matrix = new int[4, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 10, 11, 12 }
        };

        // Print the elements of the 2D array
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Declare sum
        int sum = 0;

        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
        }
        Console.WriteLine("Sum of all elements in the array: " + sum);

        int DiagonalSum = 0;
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j)
                {
                    DiagonalSum += matrix[i, j];
                }
            }
        }
        Console.WriteLine("Sum of diagonal elements in the array: " + DiagonalSum);
    }
}
