using System;

class ThirdDigitSeven
{
    static void Main()
    {
        /*
         *  Problem 5: Third digit is 7?
         *  
         *  - Write an expression that checks for given integer if its third digit from right-to-left is 7.
         * 
         * */

        int input;
        int result;

        Console.Title = "Third digit is 7?";

        Console.WriteLine("The program checks for given integer if its third digit from right-to-left is 7.");

        Console.Write("Enter your integer: ");
        input = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        input = Math.Abs(input);

        result = input / 10;
        result = result % 100;
        result = result / 10;

        if (result == 7)
        {
            Console.WriteLine("True! The third digit is 7.\n");
        }
        else
        {
            Console.WriteLine("False! The third digit is not 7.\n");
        }
    }
}

