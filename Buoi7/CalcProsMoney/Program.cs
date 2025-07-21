public class CalcProsMoney
{
    public static void Main(string[] args)
    {
        double money = 1.0f;
        int month = 1;
        double intersetRate = 1.0f;

        Console.Write("Enter the money amount: ");
        money = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the interest rate (as a decimal): ");
        intersetRate = Convert.ToDouble(Console.ReadLine());


        while (month <= 12)
        {
            money = money * intersetRate;
            money = Math.Round(money, 2);
            Console.WriteLine($"Month: {month}, Money: {money}");
            month++;
        }
        
        Console.WriteLine($"Total money after 12 months: {money}");
    }
}
