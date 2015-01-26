using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        /*
         *  Problem 1: Sum of 3 Numbers
         *  
         *  - Write a program that reads 3 real numbers from the console and prints their sum.
         * 
         * */

        double fstNum;
        double sndNum;
        double trdNum;
        double sum;

        Console.Title = "Sum of Three numbers";

        Console.WriteLine("The program reads 3 real numbers from the console and prints their sum.\n");

        Console.Write("Enter the 1st number: ");
        fstNum = Double.Parse(Console.ReadLine());

        Console.Write("Enter the 2nd number: ");
        sndNum = Double.Parse(Console.ReadLine());

        Console.Write("Enter the 3rd number: ");
        trdNum = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        sum = fstNum + sndNum + trdNum;

        Console.WriteLine("Sum = {0}\n", sum);
    }
}