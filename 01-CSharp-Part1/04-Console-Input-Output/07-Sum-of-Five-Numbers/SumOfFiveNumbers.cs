using System;
using System.Text;
using System.Globalization;

class SumOfFiveNumbers
{
    static void Main()
    {
        /*
         *  Problem 7: Sum of 5 numbers
         *  
         *  - Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
         * 
         * */
                
        Console.Title = "Sum of 5 numbers";

        Console.WriteLine("The program reads 5 numbers (given in a single line, separated by a space), \ncalculates and prints their sum.");

        Console.Write("Enter the numbers: ");
        string input = Console.ReadLine();              // Reading the numbers as a string
        Console.WriteLine();

        string[] numbersStr = input.Split(' ');         // Spliting them and assigning them into an array of strings
        double[] numbers = new double[5];               // Initializing an array of size 5, where our numbers will be stored.
        double sum = 0;

        for (int i = 0; i < 5; i++)                     // Filling the array 
        {
            numbers[i] = Double.Parse(numbersStr[i]);
            sum += numbers[i];
        }
               
        Console.WriteLine("The sum is: {0}\n", sum);
    }
}