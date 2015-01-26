using System;
using System.Text;

class ASCIITable
{
    static void Main()
    {
        /*
         *  Problem 14*: Print the ASCII Table
         * 
         *  - Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that print the entire ASCII table of characters on the console (characters from 0 to 255).
         *  
         *  - Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.
         * 
         *  - Note: You may need to use for-loops (learn in Internet how).
         *  
         * */

        Console.OutputEncoding = Encoding.Unicode;

        Console.Title = "ASCII Table";

        Console.WriteLine(" ASCII Table:\n");
        
        string dec = "Dec";
        string oct = "Oct";
        string hex = "Hex";
        string bin = "Bin";
        string symbol = "Symbol";
        string hexOutput;
        string binOutput;
        string octOutput;
        
        Console.WriteLine(" {0,4} | {1,4} | {2,4} | {3,8} | {4}", dec, oct, hex, bin, symbol);

        for (int i = 0; i <= 255; i++)
			{
                hexOutput = String.Format("{0:X}", i);
                binOutput = Convert.ToString(i, 2).PadLeft(8,'0');
                octOutput = Convert.ToString(i, 8).PadLeft(3,'0');               
                
                Console.Write(" {0,4} | {1,4} | {2,4} | {3,8} | {4}\n", i, octOutput, hexOutput, binOutput, (char)i);                
			}        
        Console.WriteLine();
    }
}