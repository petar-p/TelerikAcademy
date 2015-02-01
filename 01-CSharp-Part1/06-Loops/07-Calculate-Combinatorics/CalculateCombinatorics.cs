using System;
using System.Numerics;

class CalculateCombinatorics
{
    static void Main()
    {
        /*
         *  Problem 7: Calculate N! / (K! * (N-K)!)
         *  
         *  - In combinatorics, the number of ways to choose k different members out of a group of n different elements 
         *    (also known as the number of combinations) is calculated by the following formula: N! / (K! * (N-K)!)
         *  
         *  - For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
         *  
         *  - Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
         *  
         *  - Try to use only two loops.
         * 
         * */

        int inputN;

        int inputK;

        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger nMinusKFact = 1;
        BigInteger result = 0;

        // Input
        Console.Write("Enter N: ");
        inputN = Int32.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        inputK = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

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

            for (int i = (inputN - inputK); i > 0; i--)             // Calculating (n-k)!
            {
                nMinusKFact *= i;
            }

            result = nFact / (kFact * nMinusKFact);

            Console.WriteLine("{0}\n", result);
        }
        else
        {
            Console.WriteLine("Invalid input! See input restriction.\n");
        }

    }
}
