public class DoWhileLoop
{
    public static void Main(string[] args)
    {
        int i = 1;
        do
        {
            Console.WriteLine($"Current value of i: {i}");
            i++;
        } while (i <= 10);
    }
}
