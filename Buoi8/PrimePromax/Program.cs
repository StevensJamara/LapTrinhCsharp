public class Program
{
    public static void Main(string[] args)
    {
        int start, end, sum = 0;
        do
        {
            Console.Write("Enter the start of the range (inclusive): ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the end of the range (inclusive): ");
            end = Convert.ToInt32(Console.ReadLine());

            if (start > end)
            {
                Console.WriteLine("Start must be less than or equal to end. Please try again.");
            }
        } while (start > end);

        for (int i = start; i < end; i++)
        {
            if (IsPrime(i))
            {
                Console.Write($"{i} ");
                sum += 1;
            }
        }
    }
    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
