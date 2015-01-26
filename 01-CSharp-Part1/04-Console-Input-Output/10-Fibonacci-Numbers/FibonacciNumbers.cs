using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        /*
         *  Problem 10: Fibonacci numbers
         *  
         *  - Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
         *    (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
         *  
         *  - Note: You may need to learn how to use loops. 
         * 
         * */

        int counter;
        BigInteger a = 0;           // Using System.Numerics Big integer, after included to project's References
        BigInteger b = 1;
        BigInteger temp = 0;

        Console.Title = "Fibonacci Sequence";

        Console.WriteLine("The program reads a number n, and prints the first n members \nof the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233,...");

        Console.Write("Enter the n-th member: ");
        counter = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        // Output:
        Console.WriteLine("Fibonacci numbers from 0 to {0}:\n", counter);

            for (int i = 0; i <= counter; i++)
            {
                Console.Write("{0}, ", temp);
                temp = a + b;
                b = a;
                a = temp;
            }
        Console.WriteLine();
        Console.WriteLine();
    }
}