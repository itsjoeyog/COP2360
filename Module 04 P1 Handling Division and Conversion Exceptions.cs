using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        DivideNumbers(input1, input2);
    }

    static void DivideNumbers(string num1, string num2)
    {
        try
        {
         
            int number1 = Convert.ToInt32(num1);
            int number2 = Convert.ToInt32(num2);

            
            int result = number1 / number2;

            
            Console.WriteLine($"Result: {number1} / {number2} = {result}");
        }
        catch (FormatException)
        {
            
            Console.WriteLine("Error: Input is not a valid number.");
        }
        catch (DivideByZeroException)
        {
           
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (Exception ex)
        {
            
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}
