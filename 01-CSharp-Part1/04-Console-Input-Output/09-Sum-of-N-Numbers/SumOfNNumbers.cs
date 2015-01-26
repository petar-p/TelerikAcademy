using System;

class SumOfNNumbers
{
    static void Main()
    {
        /*
         *  Problem 9: Sum of N Numbers
         *  
         *  - Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
         *  
         *  - Note: You may need to use a for-loop.
         * 
         * */

        int input;
        int currentInput;
        int sum = 0;

        Console.Title = "Sum of N numbers";

        Console.WriteLine("The program reads a number n, and after that enters more n numbers \nand calculates and prints their sum.\n");

        Console.Write("Enter the number n: ");
        input = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 0; i < input; i++)
        {
            Console.Write("Enter the next number to sum up: ");
            currentInput = Int32.Parse(Console.ReadLine());

            sum = sum + currentInput; 
        }

        Console.WriteLine();
        Console.WriteLine("The sum of all numbers you entered is: {0}\n", sum);
    }
}