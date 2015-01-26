using System;

class NumberComparer
{
    static void Main()
    {
        /*
         *  Problem 4: Number comparer
         *  
         *  - Write a program that gets two numbers from the console and prints the greater of them.
         *  
         *  - Try to implement this without if statements.
         * 
         * */

        double fstNum;
        double sndNum;
        bool greater;

        Console.Title = "Number comparer";

        Console.WriteLine("The program reads two numbers from the console and prints the greater of them.\n");

        Console.Write("Enter 1st number: ");
        fstNum = Double.Parse(Console.ReadLine());

        Console.Write("Enter 2nd number: ");
        sndNum = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        greater = fstNum > sndNum;

        Console.WriteLine(greater ? fstNum : sndNum);
        Console.WriteLine();
    }
}