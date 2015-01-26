using System;

class NumbersInInterval
{
    static void Main()
    {
        /*
         *  Problem 11:* Numbers in Interval Dividable by Given Number
         *  
         *  - Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
         * 
         * */

        int startNum;
        int endNum;
        int p = 0;
        string result = ""; 
        
        Console.Title = "Numbers in Interval Divisible by Given Number";

        Console.WriteLine("The program reads two positive integer numbers and prints how many numbers p");
        Console.WriteLine("exist between them such that the reminder of the division by 5 is 0.\n");

        Console.Write("Enter start number: ");
        startNum = Int32.Parse(Console.ReadLine());

        Console.Write("Enter end number: ");
        endNum = Int32.Parse(Console.ReadLine());

        for (int i = startNum; i <= endNum; i++)
        {
            if (i % 5 == 0)
            {
                result = result + i + ", "; 
                p++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("The p numbers are: {0}\n", p);
        Console.WriteLine("{0}\n", result);
    }
}