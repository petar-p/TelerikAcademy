using System;

class BitwiseExtractBitThree
{
    static void Main()
    {
        /*
         *  Problem 11: Bitwise: Extract Bit#3
         *  
         *  - Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
         *  
         *  - The bits are counted from right to left, starting from bit #0.
         *  
         *  - The result of the expression should be either 1 or 0.
         * 
         * */

        uint input;
        uint result;
        string inputNum;

        Console.Title = "Bitwise: Extract Bit #3";

        Console.WriteLine("The program finds the value of the bit #3 of a given unsigned integer.\n");

        Console.Write("Enter your positive integer: ");
        input = UInt32.Parse(Console.ReadLine());
        Console.WriteLine();

        inputNum = Convert.ToString(input,2).PadLeft(32, '0');

        result = input & 8;

        Console.WriteLine("Your number: {0}\n", inputNum);

        Console.WriteLine((result == 8) ? "The third bit is: 1\n" : "The third bit is: 0\n");        
    }
}
