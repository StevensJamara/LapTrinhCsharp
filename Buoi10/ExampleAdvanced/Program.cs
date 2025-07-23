using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Generate a 2D array with random numbers from 1 to 100
        int rows = 4;
        int cols = 5;
        int[,] randomMatrix = new int[rows, cols];
        Random rand = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                randomMatrix[i, j] = rand.Next(1, 101); // 1 to 100 inclusive
            }
        }

        // Print the 2D random array
        Console.WriteLine("Random 2D array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(randomMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Calculate sum of the 2D random array
        int matrixSum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrixSum += randomMatrix[i, j];
            }
        }
        Console.WriteLine("Sum of 2D random array: " + matrixSum);
    }
}