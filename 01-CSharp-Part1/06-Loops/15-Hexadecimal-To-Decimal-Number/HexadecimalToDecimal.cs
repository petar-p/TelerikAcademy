using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        /*
         *  Problem 15: Hexadecimal to Decimal Number
         *  
         *  - Using loops write a program that converts a hexadecimal integer number to its decimal form.
         *  
         *  - The input is entered as string. The output should be a variable of type long.
         *  
         *  - Do not use the built-in .NET functionality.
         * 
         * */

        Console.Title = "Hexadecimal to Decimal";
        Console.WriteLine("The program converts a hexadecimal integer number to its decimal form.\n");

        Console.WriteLine("Enter the hexadecimal number:");
        string input = Console.ReadLine();
        Console.WriteLine();

        int lenght = (input.Length) - 1;
        int power = lenght;
        long result = 0;
        long sum = 0;
        int pos;

        Console.WriteLine("Hex number: {0}", input);

        for (int i = 0; i <= lenght; i++)
        {
            pos = input[i];

            switch (input[i])
            {
                case '0': pos = 0; break;
                case '1': pos = 1; break;
                case '2': pos = 2; break;
                case '3': pos = 3; break;
                case '4': pos = 4; break;
                case '5': pos = 5; break;
                case '6': pos = 6; break;
                case '7': pos = 7; break;
                case '8': pos = 8; break;
                case '9': pos = 9; break;
                case 'A': pos = 10; break;
                case 'a': pos = 10; break;
                case 'B': pos = 11; break;
                case 'b': pos = 11; break;
                case 'C': pos = 12; break;
                case 'c': pos = 12; break;
                case 'D': pos = 13; break;
                case 'd': pos = 13; break;
                case 'E': pos = 14; break;
                case 'e': pos = 14; break;
                case 'F': pos = 15; break;
                case 'f': pos = 15; break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid input!\n");
                    Environment.Exit(0);
                    break;
            }

            result = pos * ((long)(Math.Pow(16, power)));
            sum = sum + result;
            power--;
        }

        Console.WriteLine("Dec number: {0}", sum);
        Console.WriteLine();
    }
}

