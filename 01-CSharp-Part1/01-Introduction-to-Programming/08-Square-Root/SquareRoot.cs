using System;

class SquareRoot
{
    static void Main()
    {
        /*
         *  Problem 8: Square root
         * 
         *  - Create a console application that calculates and prints the square root of the number 12345.
         *  - Find in Internet “how to calculate square root in C#”.
         *  
         * */

        Console.Title = "Square root";

        double root = Math.Sqrt(12345);

        Console.WriteLine("The square root of 12345 is {0}", root);
        Console.WriteLine();
    }
}