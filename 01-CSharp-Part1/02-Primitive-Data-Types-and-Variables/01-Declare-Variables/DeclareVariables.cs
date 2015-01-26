using System;

class DeclareVariables
{
    static void Main()
    {
        /*
         *  Problem 1: Declare variables
         * 
         *  - Declare five variables choosing for each of them the most appropriate of 
         *    the types byte, sbyte, short, ushort, int, uint, long, ulong 
         *    to represent the following values: 52130, -115, 4825932, 97, -10000.
         *  
         *  - Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
         *  
         * */

        ushort var1 = 52130;
        sbyte var2 = -115;
        int var3 = 4825932;
        byte var4 = 97;
        short var5 = -10000;

        Console.Title = "Declaring variables";

        Console.WriteLine("Using different variable types:");
        Console.WriteLine();

        Console.WriteLine("{0,7}: used variable type 'ushort'", var1);
        Console.WriteLine("{0,7}: used variable type 'sbyte'", var2);
        Console.WriteLine("{0,7}: used variable type 'int'", var3);
        Console.WriteLine("{0,7}: used variable type 'byte'", var4);
        Console.WriteLine("{0,7}: used variable type 'short'", var5);
        Console.WriteLine();
    }
}