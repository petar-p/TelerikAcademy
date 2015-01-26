using System;

class LongSequence
{
    static void Main()
    {
        /*
         *  Problem 16: Print Long Sequence
         *  
         *  - Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
         *  
         *  - You might need to learn how to use loops in C# (search in Internet).
         * 
         * */

        Console.Title = "Long sequence";

        int member = 2;

        for (int i = 0; i < 500; i++)
        {
            Console.Write(member);
            member++;
            Console.Write(", -" + member + ", ");
            member++;
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}