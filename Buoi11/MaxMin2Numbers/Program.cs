public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Find and display the maximum and minimum values
        int max = FindMax(num1, num2);
        int min = num1 < num2 ? num1 : num2;
        Console.WriteLine($"Maximum value: {max}");
        Console.WriteLine($"Minimum value: {min}");
    }

    public static int FindMax(int a, int b)
    {
        return a > b ? a : b;
    }
}

