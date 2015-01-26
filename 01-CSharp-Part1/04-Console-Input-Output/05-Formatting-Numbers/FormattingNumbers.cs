using System;

class FormattingNumbers
{
    static void Main()
    {
        /*
         *  Problem 5: Formatting numbers
         *  
         *  - Write a program that reads 3 numbers:
         *  
         *      - integer a (0 <= a <= 500)
         *      - floating-point b
         *      - floating-point c
         *  
         *  - The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
         *  
         *      - The number a should be printed in hexadecimal, left aligned
         *      - Then the number a should be printed in binary form, padded with zeroes
         *      - The number b should be printed with 2 digits after the decimal point, right aligned
         *      - The number c should be printed with 3 digits after the decimal point, left aligned.
         * 
         * */

        int firstNum;
        double secondNum;
        double thirdNum;

        Console.Title = "Formatting numbers";

        Console.WriteLine("The program reads 3 numbers and formats them in 4 individual columns:");

        Console.Write("Enter first number: ");
        firstNum = Int32.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        secondNum = Double.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number: ");
        thirdNum = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        if ((firstNum >=0) && (firstNum <= 500))
        {
            Console.WriteLine("{0,10}|{1, 10}|{2,10:f2}|{3,-10:f3}\n",
            Convert.ToString(firstNum, 16),
            Convert.ToString(firstNum, 2).PadLeft(10, '0'),
            secondNum, thirdNum);
        }
        else
        {
            Console.WriteLine("Invalid input! The first number should be between 0 and 500.");
        }
        

    }
}
