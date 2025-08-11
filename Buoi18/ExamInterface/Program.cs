public class Program
{
    public static void Main(string[] args)
    {
        Player player = new Player(100);
        player.TakeDamage(30);
        player.TakeDamage(80); // This should trigger the death logic
        player.Destroy(); // Explicitly call destroy method
        Console.WriteLine($"Is player destroyed? {player.IsDestroyed}");

        
    }
}
