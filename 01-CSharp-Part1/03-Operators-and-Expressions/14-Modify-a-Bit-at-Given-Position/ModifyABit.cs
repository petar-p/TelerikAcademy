using System;

class ModifyABit
{
    static void Main()
    {
        /*
         *  Problem 14: Modify a Bit at Given Position
         * 
         *  - We are given an integer number n, a bit value v (v=0 or 1) and a position p.
         *  
         *  - Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p 
         *    from the binary representation of n while preserving all other bits in n.
         *  
         * */
                 

        int num;
        int pos;
        int value;
        int mask;
        int numAndMask;        

        string inputNum;
        string modifiedNum;

        Console.Title = "Modify a Bit at Given Position";

        Console.WriteLine("The program modifies a bit at position p, of a given integer n, \nto a value (0 or 1).\n");

        // Input
        Console.Write("Enter the integer: ");
        num = Int32.Parse(Console.ReadLine());

        Console.Write("Enter the position: ");
        pos = Int32.Parse(Console.ReadLine());

        Console.Write("Enter the value: ");
        value = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        mask = 1 << pos;

        inputNum = Convert.ToString(num, 2).PadLeft(32, '0');        

        Console.WriteLine("Number before the modification: {0}\n", inputNum);

            if (value == 0)
            {
                numAndMask = num & ~(mask);
                modifiedNum = Convert.ToString(numAndMask, 2).PadLeft(32, '0');
                Console.WriteLine("Number after the modification : {0}\n", modifiedNum);
            }
            else
            {
                numAndMask = num | mask;
                modifiedNum = Convert.ToString(numAndMask, 2).PadLeft(32, '0');
                Console.WriteLine("Number after the modification : {0}\n", modifiedNum);
            }    //             
    }
}