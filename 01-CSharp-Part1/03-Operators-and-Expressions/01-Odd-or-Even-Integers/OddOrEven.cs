using System;

class OddOrEven
{
    static void Main()
    {
        /*
         *  Problem 1: Odd or Even integers
         *  
         *  - Write an expression that checks if given integer is odd or even.
         * 
         * */

        int input;

        Console.Title = "Odd or Even Integers";

        Console.WriteLine("This program checks whether a given integer is odd or even.\n");

        Console.Write("Enter your integer: ");
        input = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine((input % 2 == 0) ? "The integer is Even!\n" : "The integer is Odd!\n");
    }
}