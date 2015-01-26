using System;

class BitAtGivenPosition
{
    static void Main()
    {
        /*
         *  Problem 13: Check a Bit at Given Position
         *  
         *  - Write a Boolean expression that returns if the bit at position p 
         *    (counting from 0, starting from the right) in given integer number n, has value of 1.
         * 
         * */

        int num;
        int pos;
        int mask;
        
        bool isOne;

        string inputNum;

        Console.Title = "Check a Bit at Given Position";

        Console.WriteLine("The program checks if the bit at position p in given integer n,\nhas the value of 1.\n");

        // Input
        Console.Write("Enter the integer: ");
        num = Int32.Parse(Console.ReadLine());

        Console.Write("Enter the position: ");
        pos = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        mask = 1 << pos;
        isOne = ((num & mask) == mask);        

        inputNum = Convert.ToString(num, 2).PadLeft(32, '0');

        Console.WriteLine("Your number: {0}\n", inputNum);

        Console.WriteLine(isOne ? "The bit has the value of 1.\n" : "The bit has the value of 0.\n");         
    }
}
