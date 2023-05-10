using practical_4;
using System;
using System.Security.Cryptography;

public class Program
{
    public static bool ValidateInput(string input, out decimal val)
    {
        return decimal.TryParse(input, out val) && (val >= 0 && val <= 100);
    }   

    public static decimal TakeInput(int i)
    {
        Console.Write($"\nEnter marks{i} : ");

        decimal val;

        bool IsValidInput = ValidateInput(Console.ReadLine(), out val);  
        
        if(!IsValidInput)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nPlease Enter marks between 0 and 100");
            Console.ForegroundColor = ConsoleColor.Yellow;
            val = TakeInput(i);
        }
        
        return val;
    }

    public static void Main(string[] args)
    {
        Student student = new Student();
         
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\nEnter student name : ");
        student.Name = Console.ReadLine();              

        for(int i=0; i<5; i++)
        {            
            student.Marks[i] = TakeInput(i+1); 
        }      

        while (true)
        {
            Console.WriteLine($"\n1-Average");
            Console.WriteLine($"2-MinMark");
            Console.WriteLine($"3-MaximumMark");
            Console.WriteLine($"4-Grade");
            Console.WriteLine($"5-Exit");
            Console.Write($"\nEnter your choise : ");

            int choice = Convert.ToInt32(Console.ReadLine());
            bool flag = false;        
            
            switch (choice)
            {
                case (int)Options.Average:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Average Marks : {student.CalculateAverageMarks(student.Marks)}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case (int)Options.MinMark:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Minimum Marks : {student.Marks.Min()}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case (int)Options.MaximumMark:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Maximum Marks : {student.Marks.Max()}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case (int)Options.Grade:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Grade : {student.CalculateGrade(student.CalculateAverageMarks(student.Marks))}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 5:
                    flag = !flag;
                    break;
                default:
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine($"Wrong option choosen");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }

            if (flag)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("THANK YOU...");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
                
        }
    }
}