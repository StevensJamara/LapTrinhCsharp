public class Program
{
    public static void Main(string[] args)
    {
        string gradle = "A";
        string result = gradle switch
        {
            "A" => "Excellent",
            "B" => "Good",
            "C" => "Normal",
            "D" => "Bad"
        };
        Console.WriteLine("",result);
    }
}