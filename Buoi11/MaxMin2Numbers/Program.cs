public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Find and display the maximum and minimum values
        PrintMaxMin(FindMax(num1, num2), FindMin(num1, num2));
    }

    public static int FindMax(int a, int b)
    {
        return a > b ? a : b;
    }
    public static int FindMin(int a, int b)
    {
        return a < b ? a : b;
    }
    public static void PrintMaxMin(int max, int min)
    {
        Console.WriteLine($"Maximum value: {max}");
        Console.WriteLine($"Minimum value: {min}");
    }
}

