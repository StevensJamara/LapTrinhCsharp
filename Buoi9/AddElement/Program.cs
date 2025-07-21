public class Program
{
    public static void Main(string[] args)
    {
        // Create an array of integers
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Print the elements of the array
        Console.WriteLine("=====================================================");
        Console.Write("Start array with elements: ");
        PrintArray(numbers);
        Console.WriteLine("=====================================================");
        Console.Write("Adding element to the array: ");
        int newElement = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Add index at: ");
        int index = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("=====================================================");
        AddElement(numbers, newElement, index);
        Console.WriteLine("");
        Console.WriteLine("=====================================================");
    }

    public static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }
    public static void AddElement(int[] array, int element, int index)
    {
        // Create a new array with one additional element
        int[] newArray = new int[array.Length + 1];

        // Copy elements from the old array to the new array
        for (int i = 0; i < array.Length; i++)
        {
            if (i < index)
            {
                newArray[i] = array[i];
            }
            else
            {
                newArray[i + 1] = array[i];
            }
        }

        // Insert the new element at the specified index
        newArray[index] = element;

        // Print the updated array
        Console.WriteLine("Updated array after adding the element:");
        PrintArray(newArray);   
    }
}
