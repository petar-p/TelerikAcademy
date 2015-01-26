using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        /*
         *  Problem 3: Divide by 7 and 5
         *  
         *  - Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
         * 
         * */

        int input;
        bool divisible;

        Console.Title = "Divide by 7 and 5";

        Console.WriteLine("This program checks if a given integer is divisible by 7 and 5 at the same time.");

        Console.Write("Enter the integer: ");
        input = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        divisible = (input % 5 == 0) && (input % 7 == 0);

        Console.WriteLine("Divisible? - {0}!\n", divisible);
    }
}