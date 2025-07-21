public class Program
{
    public static void Main(string[] args)
    {
        // Create an array of integers
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        List<string> numbers2 = new List<string> { "Dog", "Pig", "Cat", "Cow", "Sheep" };

        numebers.Add(6);
        
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine($"List 1: {numbers[i]}");
        }

        foreach (string animal in numbers2)
        {
            Console.Write($"{animal} ");
        }
    }
}
