using System;
using System.Linq;


class DecimalToBinary
{
    static void Main()
    {
        /*
         *  Problem 14: Decimal to Binary
         *  
         *  - Using loops write a program that converts an integer number to its binary representation.
         *  
         *  - The input is entered as long. The output should be a variable of type string.
         *  
         *  - Do not use the built-in .NET functionality.
         *  
         * */

        long input;
        long result = 0;

        string str = "";

        Console.Title = "Decimal to Binary";
        Console.WriteLine("The program converts an integer number to its binary representation.");
        Console.WriteLine("*Note: The program converts only positive integers.\n");

        // Input
        Console.Write("Enter the decimal integer number: ");
        input = Int64.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Dec number: {0}", input);

        // The algorithm works only for positive integers

        if (input > 0)
        {
            // Performing the conversion just like doing it by hand. 
            while (input > 0)
            {
                result = input % 2;
                input = input / 2;
                str = str + Convert.ToString(result);
            }

            // Once we have the 0's and 1's, we have to revert them to get the actual binary number. 
            string[] bin = new string[str.Length];

            Console.Write("Bin number: ");

            // Reverse the string
            for (int i = str.Length - 1, j = 0; i >= 0; i--, j++)
            {
                bin[j] = str[i].ToString();
                Console.Write(bin[j]);
            }
            Console.WriteLine();
            Console.WriteLine();            
        }
        else
        {
            Console.WriteLine("Bin number: 0\n");
        }
    }
}