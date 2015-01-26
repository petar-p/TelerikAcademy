using System;

class FourDigitNumber
{
    static void Main()
    {
        /*
         *  Problem 6: Four Digit Number
         *  
         *  - Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
         *  
         *      - Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
         *      - Prints on the console the number in reversed order: dcba (in our example 1102).
         *      - Puts the last digit in the first position: dabc (in our example 1201).
         *      - Exchanges the second and the third digits: acbd (in our example 2101).
         * 
         * */

        Console.Title = "Four Digit Number";

        Console.WriteLine("The program reads four-digit number in format abcd (e.g. 2011) and performs the following:\n");
        Console.WriteLine("- Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4)");
        Console.WriteLine("- Prints on the console the number in reversed order: dcba (in our example 1102)");
        Console.WriteLine("- Puts the last digit in the first position: dabc (in our example 1201)");
        Console.WriteLine("- Exchanges the second and the third digits: acbd (in our example 2101)\n");

        Console.Write("Enter your number: ");
        int num = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        int d = num % 10;
        num = num / 10;
        int c = num % 10;
        num = num / 10;
        int b = num % 10;
        num = num / 10;
        int a = num % 10;

        int sum = a + b + c + d;

        Console.WriteLine("{0}", sum);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}\n", a, c, b, d);
    }
}

