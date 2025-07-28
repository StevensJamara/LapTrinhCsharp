public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];

        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            numbers[i] = rnd.Next(0, 100);
        }

        Console.WriteLine("Generated array:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Find and display the maximum value
        int maxValue = Max(numbers);
        int minValue = Min(numbers);
        Console.WriteLine($"Maximum value: {maxValue}");
        Console.WriteLine($"Minimum value: {minValue}");
    }

    public static int Max(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty");
        }
        int max = arr[0];
        foreach (int num in arr)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }

    public static int Min(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty");
        }
        int min = arr[0];
        foreach (int num in arr)
        {
            if (num < min)
            {
                min = num;
            }
        }
        return min;
    }
}
