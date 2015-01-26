using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        /*
         *  Problem 8: Numbers from 1 to N
         *  
         *  - Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
         * 
         * */

        int input;

        Console.Title = "Numbers from 1 to N";

        Console.WriteLine("The program reads an integer number n from the console \nand prints all the numbers in the interval [1..n], each on a single line.\n");
        
        Console.Write("Enter the number n: ");
        input = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= input; i++)
        {
            Console.Write("{0}, ", i);
        }
        Console.WriteLine("\n");
    }
}