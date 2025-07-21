public class Program
{
    public static void Main(string[] args)
    {
        string[] animals = { "Dog", "Pig", "Cat", "Cow", "Sheep", "Goat", "Chicken", "Duck" };
        Console.Write("Enter an animal name to find its index in the array: ");
        string input = Console.ReadLine();

        bool isExists = false;
        for (int i = 0; i < animals.Length; i++)
        {
            if (animals[i].Equals(input, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"The animal '{input}' is found at index {i}.");
                isExists = true;
                break;
            }
        }
        if (!isExists)
        {
            Console.WriteLine($"The animal '{input}' is not found in the array.");
        }
    }
}
