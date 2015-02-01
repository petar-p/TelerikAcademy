using System;

class MatrixOfNumbers
{
    static void Main()
    {
        /*
         *  Problem 9: Matrix of Numbers
         *  
         *  - Write a program that reads from the console a positive integer number n (1 = n = 20) 
         *    and prints a matrix like in the examples below. 
         * 
         *  - Use two nested loops.
         * 
         * */

        int input;

        Console.Title = "Matrix of numbers";

        Console.WriteLine("The program reads from the console a positive integer number n (1 = n = 20)");
        Console.WriteLine("and prints a matrix like in the examples below.\n");

        // Input
        Console.Write("Enter the number n: ");
        input = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        if ((input >= 1) && (input <= 20))                  // Checks input restriction (1 = n = 20) 
        {
            for (int row = 0; row < input; row++)           // Outer loop for printing rows
            {
                for (int col = 1; col <= input; col++)      // Inner loop for printing columns
                {
                    Console.Write("{0,2} ", col + row);     
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input! See input restrictions.\n");
        }       
    }
}