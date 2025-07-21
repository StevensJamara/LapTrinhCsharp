public class Menu 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Menu Chooser!");
        Console.WriteLine("1. Triangle Pattern");
        Console.WriteLine("2. Triangle Pattern Inverted");
        Console.WriteLine("3. Square Pattern");
        Console.WriteLine("0. Exit");
        Console.Write("Enter your choice: ");
        int choice = 0;
        
        while (choice != 0)
        {
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < i + 1; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case 2:
                        for (int i = 5; i > 0; i--)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case 3:
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine("");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Exiting the menu. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input, please enter a number.");
            }
        }
    }
}
