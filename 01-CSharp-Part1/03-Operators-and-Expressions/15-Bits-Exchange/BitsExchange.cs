using System;

class BitsExchange
{
    static void Main()
    {
        /*
         *  Problem 15:* Bits Exchange
         *  
         *  - Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
         * 
         * */

        // More info about swapping bits and bitwise operations at: 
        // http://graphics.stanford.edu/~seander/bithacks.html#SwappingBitsXOR

        uint b;                                 // your number
        int i = 3;                              // starting position of the first swapped sequence i = 3 (3, 4, 5)
        int j = 24;                             // starting position of the second swapped sequence j = 24 (24, 25, 26)
        int n = 3;                              // number of consecutive bits in each sequence n = 3         
        long r;                                 // the result
        long x;                                 // XOR temporary

        string bitInput;
        string bitResult;

        Console.Title = "Bits Exchange";

        Console.WriteLine("The program exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of \ngiven 32-bit unsigned integer.\n");

        Console.Write("Enter your number: ");
        b = UInt32.Parse(Console.ReadLine());                // your number
        Console.WriteLine();

        bitInput = Convert.ToString(b, 2).PadLeft(32, '0');

        x =(long)((b >> i) ^ (b >> j)) & ((1 << n) - 1);     // XOR temporary

        r = (long) b ^ ((x << i) | (x << j));                // result

        bitResult = Convert.ToString(r, 2).PadLeft(32, '0');

        Console.WriteLine("Before the exchange: {0}", bitInput);        
        Console.WriteLine("After the exchange : {0}\n", bitResult);
        Console.WriteLine("Modified number: {0}\n", r);
    }
}