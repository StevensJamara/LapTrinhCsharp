public class Program
{
    public static void Main(string[] args)
    {
        // Create a dictionary to hold string keys and integer values
        Dictionary<string, int> ages = new Dictionary<string, int>
        {
            { "Alice", 30 },
            { "Bob", 25 },
            { "Charlie", 35 }
        };

        // Add a new key-value pair to the dictionary
        ages.Add("David", 28);

        // Print the keys and values in the dictionary
        foreach (var kvp in ages)
        {
            Console.WriteLine($"{kvp.Key} is {kvp.Value} years old.");
        }

        // Check if a key exists in the dictionary
        if (ages.ContainsKey("Alice"))
        {
            Console.WriteLine("Alice's age is known.");
        }
    }
}
