using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        /*
         *  Problem 8: Catalan Numbers
         *  
         *  - Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).
         *  
         *  - In combinatorics, the Catalan numbers are calculated by the following formula: 
         *    Cn = (2n)! / n! x (n+1)!  
         * 
         * */

        int input;
        int inputPlusOne;
        int inputDouble;

        BigInteger nFact = 1;
        BigInteger inputPlusOneFact = 1;
        BigInteger inputDoubleFact = 1;
        BigInteger result = 0;

        Console.Title = "Catalan numbers";

        Console.WriteLine("The program calculates the n-th Catalan number by given n (1 <= n <= 100).");
        Console.WriteLine("The n-th Catalan number is: Cn = (2n)! / n! x (n+1)!\n");       

        // Input
        Console.Write("Enter number n: ");
        input = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        inputPlusOne = input + 1;
        inputDouble = input * 2;

        if ((input >= 1) && (input <= 100))                 // Checks input restriction (1 <= n <= 100)
        {
            for (int i = 1, k = inputPlusOne; i <= input; i++, k--)
            {
                nFact *= i;                                 // Calculating n!

                if (k > 0)                                  // Make sure k doesn't hit the bottom
                {
                    inputPlusOneFact *= k;                  // Calculating (n+1)!
                }
            }

            for (int j = 1; j <= inputDouble; j++)
            {
                inputDoubleFact *= j;                       // Calculating (2n)!
            }

            result = inputDoubleFact / (inputPlusOneFact * nFact);

            Console.WriteLine("The Catalan number ({0}) = {1}\n", input, result);
        }
        else                                                
        {
            Console.WriteLine("Invalid input! See input restrictions.\n");
        }
    }
}