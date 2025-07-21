public class ShapeDisplay
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Shape Display Program");
        Console.WriteLine("1. Square");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Rectangle Reversed");
        Console.Write("Choose a shape to display (1-3): ");

        int choice = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine();
        switch (choice)
        {
            case 1:
                DisplaySquare();
                break;
            case 2:
                DisplayRectangle();
                break;
            case 3:
                DisplayRectangle();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private static void DisplaySquare()
    {
        int size = 5; // Size of the square
        Console.Write("Enter the size of the square: ");
        size = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    private static void DisplayRectangle()
    {
        Console.WriteLine("Displaying a Rectangle:");
        // Logic to display a rectangle
    }
    
    private static void DisplayRectangleReversed()
    {
        Console.WriteLine("Displaying a Rectangle:");
        // Logic to display a rectangle
    }
}
