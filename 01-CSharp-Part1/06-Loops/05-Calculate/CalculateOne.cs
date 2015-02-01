using System;
using System.Numerics;

class CalculateOne
{
    static void Main()
    {
        /*
         *  Problem 5: Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
         *  
         *  - Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
         *  
         *  - Use only one loop. Print the result with 5 digits after the decimal point.
         * 
         * */

        int inputX;
        int inputN;
        double sum = 1;

        BigInteger nFactorial = 1;

        Console.Title = "Problem 5: Calculus";

        Console.WriteLine("The program reads two integer numbers N and X, and calculates the sum \nS = 1 + 1!/x + 2!/x2 + … + n!/x^n.\n");

        // Input
        Console.Write("Enter the number N: ");
        inputN = Int32.Parse(Console.ReadLine());

        Console.Write("Enter the number X: ");
        inputX = Int32.Parse(Console.ReadLine());
        Console.WriteLine();        

        for (int i = 1; i <= inputN ; i++)
        {
            nFactorial *= i;
            sum = sum + (double)(nFactorial) / (Math.Pow(inputX, i)); 
        }

        Console.WriteLine("Sum = {0:f5}\n", sum);
    }
}