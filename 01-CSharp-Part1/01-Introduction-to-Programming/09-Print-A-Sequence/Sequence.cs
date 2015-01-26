using System;

class Sequence
{
    static void Main()
    {
        /*
         *  Problem 9: Print a sequence
         *  
         *  - Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
         *  
         * */

        Console.Title = "Sequence";

        int member = 2;

        for (int i = 0; i < 5; i++)
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