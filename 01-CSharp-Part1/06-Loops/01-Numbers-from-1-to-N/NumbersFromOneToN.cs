using System;

class NumbersFromOneToN
{
    static void Main()
    {
        /*
         *  Problem 1: Numbers from 1 to N
         *  
         *  - Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
         * 
         * */

        int number;
        string input;
        bool parseSuccess;

        Console.Title = "Numbers from 1 to N";

        Console.WriteLine("The program reads a positive integer n and prints all the numbers from 1 to n, \non a single line, separated by a space.\n");

        // Input
        Console.Write("Enter the number n: ");
        input = Console.ReadLine();
        Console.WriteLine();

        parseSuccess = Int32.TryParse(input, out number);  // When parse fails number = 0 (the default value) 

        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write("{0} ", i);
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
