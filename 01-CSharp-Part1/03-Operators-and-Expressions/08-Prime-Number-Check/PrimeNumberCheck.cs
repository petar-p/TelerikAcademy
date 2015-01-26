using System;

class PrimeNumberCheck
{
    static void Main()
    {
        /*
         *  Problem 8: Prime number check
         *  
         *  - Write an expression that checks if given positive integer number n (n = 100) is prime 
         *    (i.e. it is divisible without remainder only to itself and 1).
         *    
         * */

        int input;

        Console.Title = "Prime number check";

        Console.WriteLine("The program checks if given positive integer number n is prime or composite.\n");

        // Implementing the primality test "Trial division" to determine whether the number is prime or composite.
        // More info about Trial division at: http://en.wikipedia.org/wiki/Primality_test 

        // Input
        Console.Write("Enter the number: ");
        input = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        bool isPrime = true;

        if ((input > 0) && (input != 1))       // Check that the number is positive and different than 1.
        {
            for (int i = 2; i < input; i++)    // Performs check from 2 to (input - 1)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                }
            }
            Console.WriteLine(isPrime ? "True! The number is prime.\n" : "False! The number is composite.\n");           
        }
        else
        {            
            Console.WriteLine("Invalid input!\nMake sure you entered positive integer or different than 1.\n");
        }
    }
}