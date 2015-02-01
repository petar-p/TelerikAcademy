using System;

class BinaryToDecimal
{
    static void Main()
    {
        /*
         *  Problem 13: Binary to Decimal Number
         *  
         *  - Using loops write a program that converts a binary integer number to its decimal form.
         *      
         *  - The input is entered as string. The output should be a variable of type long.
         *  
         *  - Do not use the built-in .NET functionality.
         *  
         * */

        string binNum;
        int dec = 0;

        Console.Title = "Binary to Decimal number ";

        Console.WriteLine("The program converts a binary integer number to its decimal form.\n");

        Console.Write("Enter the binary number: ");
        binNum = Console.ReadLine();
        Console.WriteLine();

        for (int i = binNum.Length - 1, j = 0; i >= 0; i--, j++)
        {
            if (binNum[i] == '1')
            {
                dec = dec | (1 << j);
            }
        }
        Console.WriteLine("Decimal number: {0}\n", dec);

        /*  Explanation:
         * 
         *  Reading the binary number as a string, for example: "00001000"
         *  The length of the string is 8, that means 8 positions we have to check.
         *  
         *  Checking from RIGHT to LEFT, because that is the way the binary numbers raise.  
         *      
         *  positions in the string[] =    0123 4567
         *                        bin =    0000 1000
         *                          i =    0123 4567
                                    j =    7654 3210
         *  
         *  // LOGIC
         *  
         *    if position i = '1',   // the first binNum[i] = '1' is WHEN i=4, and j=3
         *      THEN
         *    dec = dec | (1 << 3)   // (1 << 3) = 0000 1000 = 8 
         * // dec =  0  | 8 = 8 
         * 
         *  With every iteration WHEN binNum[i] = '1', we perform an addition to dec with the shifted (1 << j)
         *  
         * */
    }
}