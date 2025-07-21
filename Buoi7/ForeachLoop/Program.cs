public class ForeachLoop 
{
    public static void Main(string[] args)
    {
        // Example of a simple foreach loop that prints each number in an array
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        foreach (int number in numbers)
        {
            Console.WriteLine($"Number: {number}");
        }
    }    
}