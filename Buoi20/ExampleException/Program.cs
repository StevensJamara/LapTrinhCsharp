public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}

