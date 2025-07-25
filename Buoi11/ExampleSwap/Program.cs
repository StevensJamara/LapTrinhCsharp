public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Input number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Before swap: num1 = {num1}, num2 = {num2}");
        Swap(ref num1, ref num2);
        Console.WriteLine($"After swap: num1 = {num1}, num2 = {num2}");
    }
    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
