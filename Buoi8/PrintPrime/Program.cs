public class Program
{
    public static void Main(string[] args)
    {
        int count = 0;
        int number = 2;
        while (count < 20)
        {
            if (IsPrime(number))
            {
                Console.Write($"{number} ");
                count++;
            }
            number++;        
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
