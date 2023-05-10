using System;

public class Program
{
    /*
    public static decimal Add(decimal number1, decimal number2)
    {
        return number1 + number2;
    }
    */



    public static void Main(string[] args)
    {
        try
        {
            Console.Write("\nEnter first number : ");
            decimal number1;
            bool IsNumber1ConversionSuccessfull = decimal.TryParse(Console.ReadLine(), out number1);

            if (IsNumber1ConversionSuccessfull)
            {
                Console.Write("\nEnter second number : ");
                decimal number2;
                bool IsNumber2ConversionSuccessfull = decimal.TryParse(Console.ReadLine(), out number2);

                if (IsNumber2ConversionSuccessfull)
                {
                    decimal sum = number1 + number2;
                    Console.WriteLine($"\nThe sum of the {number1} and {number2} is {sum}");

                    decimal substraction = number1 - number2;
                    Console.WriteLine($"\nThe substraction of the {number1} and {number2} is {substraction}");

                    decimal multiplication = number1 * number2;
                    Console.WriteLine($"\nThe multiplication of the {number1} and {number2} is {multiplication}");
                
                    if(number2 == 0)
                    {
                        Console.WriteLine($"\nCannot divide {number1} by {number2}");
                    }
                    else
                    {
                        decimal division = number1 / number2;
                        Console.WriteLine($"\nThe division of the {number1} and {number2} is {division}");
                    }

                }
                else
                {
                    Console.WriteLine($"\nThe number must be between {decimal.MinValue} and {decimal.MaxValue}");
                }
            }
            else
            {
                Console.WriteLine($"\nThe number must be between {decimal.MinValue} and {decimal.MaxValue}");
            }
        }
        catch(Exception e)
        {
            Console.WriteLine($"\n{e.Message}");
        }

        Console.ReadLine();
    }
}

/*
Case1: if user enters very large number  
Case2: if user enters space between number
 
 
 
 */