using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        /*
         *  Problem 12: Extract Bit From Integer
         *  
         *  - Write an expression that extracts from given integer n the value of given bit at index p.
         * 
         * */

        int num;
        int pos;
        int mask;
        int numAndMask;
        int bit;

        string inputNum;

        Console.Title = "Extract Bit From Integer";

        Console.WriteLine("The program extracts from given integer n the value of given bit at index p.\n");

        // Input
        Console.Write("Enter the integer: ");
        num = Int32.Parse(Console.ReadLine());

        Console.Write("Enter the position: ");
        pos = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        mask = 1 << pos;
        numAndMask = num & mask;
        bit = numAndMask >> pos;

        inputNum = Convert.ToString(num, 2).PadLeft(32, '0');

        Console.WriteLine("Your number: {0}\n", inputNum);

        Console.WriteLine("The bit at position {0} is {1}.\n", pos, bit);
    }
}