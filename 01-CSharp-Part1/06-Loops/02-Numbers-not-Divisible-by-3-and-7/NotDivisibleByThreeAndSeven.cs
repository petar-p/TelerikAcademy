using System;

class NotDivisibleByThreeAndSeven
{
    static void Main()
    {
        /*
         *  Problem 2: Numbers Not Divisible by 3 and 7
         *  
         *  - Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.
         * 
         * */

        int number;
        string input;
        bool parseSuccess;

        Console.Title = "Numbers Not Divisible by 3 and 7";

        Console.WriteLine("The program reads a positive integer n and prints all the numbers from 1 to n \nnot divisible by 3 and 7, on a single line, separated by a space.\n");

        // Input
        Console.Write("Enter the number n: ");
        input = Console.ReadLine();
        Console.WriteLine();

        parseSuccess = Int32.TryParse(input, out number);  // When parse fails number = 0 (the default value) 

        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                {
                    Console.Write("{0} ", i);
                }
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input.\n");
        }                
    }
}