public class Program
{
    public static void Main(string[] args)
    {
        int grade = 85;
        string status = (grade >= 90) ? "Excellent" :
                        (grade >= 80) ? "Good" :
                        (grade >= 70) ? "Normal" :
                        (grade >= 60) ? "Bad" : "Fail";
        Console.WriteLine(status);
    }
}