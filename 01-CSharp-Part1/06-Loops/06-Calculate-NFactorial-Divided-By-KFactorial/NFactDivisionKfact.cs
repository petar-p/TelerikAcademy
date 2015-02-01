using System;
using System.Numerics;

class NFactDivisionKfact
{
    static void Main()
    {
        /*
         *  Problem 6: Calculate N! / K!
         *  
         *  - Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
         *  
         *  - Use only one loop.
         * 
         * */

        int inputN;
        int inputK;

        Console.Title = "Calculate N! / K!";

        Console.WriteLine("The program calculates n! / k! for given n and k (1 < k < n < 100).\n");

        // Input
        Console.Write("Enter N: ");
        inputN = Int32.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        inputK = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger result = 0;

        if ((inputK > 1) && (inputN > inputK) && (inputN < 100))    // Checks restricion (1 < k < n < 100)
        {
            for (int n = 1, k = inputK; n <= inputN; n++, k--)      // Increasing n, decreasing k
            {
                nFact *= n;

                if (k > 0)                                          // Make sure k doesn't hit the bottom
                {
                    kFact *= k;
                }
            }

            result = nFact / kFact;

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid input! See input restriction.\n");
        }
    }
}