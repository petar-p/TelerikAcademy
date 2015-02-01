using System;

class Program
{
    static void Main()
    {
        /*
         *  Problem 11: Random Numbers in Given Range
         *  
         *  - Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
         * 
         * */

        int inputN;         // Number of n random numbers
        int min;            // Min value of the range
        int max;            // Max value of the range
        int number;         // The current random number

        Random randNum = new Random();

        Console.Title = "Random numbers in given range";
        Console.WriteLine("The program reads 3 integers n, min and max (min != max) \nand prints n random numbers in the range [min...max].\n");

        // Input
        Console.Write("Enter the number n: ");
        inputN = Int32.Parse(Console.ReadLine());

        Console.Write("Enter the minimal value of the range: ");
        min = Int32.Parse(Console.ReadLine());

        Console.Write("Enter the maximal value of the range: ");
        max = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        if ((min < max) && (min != max))
        {
            Console.WriteLine("The random numbers from {0} to {1} are:", min, max);

            for (int i = 0; i < inputN; i++)
            {
                number = randNum.Next(min, max);
                Console.Write("{0}, ", number);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input!\n");        
        }
    }   
}

