using System;

class HexFormat
{
    static void Main()
    {
        /*
         *  Problem 3: Variable in Hexadecimal Format
         * 
         *  - Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
         *  
         *  - Use Windows Calculator to find its hexadecimal representation.
         *  
         *  - Print the variable and ensure that the result is 254.
         *  
         * */

        int value = 254;
        string hexOutput = String.Format("{0:X}", value);

        Console.Title = "Hexadecimal Format";

        Console.WriteLine("The hexadecimal representation of 254 is: {0}", hexOutput);
        Console.WriteLine();
    }
}