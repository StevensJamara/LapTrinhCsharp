public class Program
{
    public static void Main()
    {
        //Example of cases where exceptions might occur
        try
        {
            Console.WriteLine("Enter number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input format: " + ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Number is too large or too small: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        //All cases of exceptions are handled here
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Index out of range: " + ex.Message);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Null reference encountered: " + ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Invalid operation: " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero: " + ex.Message);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Argument cannot be null: " + ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Argument out of range: " + ex.Message);
        }
        catch (TimeoutException ex)
        {
            Console.WriteLine("Operation timed out: " + ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("Access denied: " + ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O error occurred: " + ex.Message);
        }
        //Specific exception handling for known issues
        catch (ArithmeticException ex)
        {
            Console.WriteLine("Arithmetic error: " + ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File not found: " + ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("Directory not found: " + ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine("Operation not supported: " + ex.Message);
        }
        //Finally block to execute code regardless of exception occurrence
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}