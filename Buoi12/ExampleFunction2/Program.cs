public class Program
{
    static Dictionary<char, int> CountCharacters(string input)
    {
        Dictionary<char, int> characterCount = new Dictionary<char, int>();
        foreach (char c in input.ToLower())
        {
            if (char.IsLetter(c))
            {
                if (characterCount.ContainsKey(c))
                {
                    characterCount[c]++;
                }
                else
                {
                    characterCount[c] = 1;
                }
            }
        }
        return characterCount;
    }
    
    public static void Main(string[] args)
    {
        Console.Write("Input a string: ");
        string input = Console.ReadLine();

        Dictionary<char, int> characterCount = CountCharacters(input);

        Console.WriteLine("Character counts:");
        foreach (var pair in characterCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
