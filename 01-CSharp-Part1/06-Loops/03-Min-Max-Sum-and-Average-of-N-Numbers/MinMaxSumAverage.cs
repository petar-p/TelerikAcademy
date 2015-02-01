using System;
using System.Linq;

class MinMaxSumAverage
{
    static void Main()
    {
        /*
         *  Problem 3: Min, Max, Sum and Average of N Numbers
         *  
         *  - Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
         *    the sum and the average of all numbers (displayed with 2 digits after the decimal point).
         *    
         *  - The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
         * 
         * */

        string input;
        bool isParsed; 

        int numbers;        
        int sum =0;
        double avg;

        Console.Title = "Min, Max, Sum and Average of N Numbers";

        Console.WriteLine("The program reads a sequence of n integer numbers and returns the minimal, ");
        Console.WriteLine("the maximal number, the sum and the average of all numbers,");
        Console.WriteLine("(displayed with 2 digits after the decimal point).\n");

        // Input
        Console.Write("Enter the number n: ");
        input = Console.ReadLine();
        Console.WriteLine();

        isParsed = Int32.TryParse(input, out numbers);

        int[] array = new int[numbers];

        if (numbers > 0)
        {
            for (int i = 0; i < numbers; i++)
            {
                Console.Write("Enter next number: ");
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }

            avg = sum / numbers;

            Console.WriteLine();
            Console.WriteLine("min = {0}", array.Min());
            Console.WriteLine("max = {0}", array.Max());
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:f2}\n", avg);
        }
        else
        {
            Console.WriteLine("Invalid input.\n");
        }

    }
}