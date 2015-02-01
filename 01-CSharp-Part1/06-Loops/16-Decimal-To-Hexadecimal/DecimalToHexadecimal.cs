using System;
using System.Linq;

class DecimalToHexadecimal
{
    static void Main()
    {
        /*
         *  Problem 16: Decimal to Hexadecimal Number
         *  
         *  - Using loops write a program that converts an integer number to its hexadecimal representation.
         *  
         *  - The input is entered as long. The output should be a variable of type string.
         *  
         *  - Do not use the built-in .NET functionality.
         *  
         * */


        string hex;
        string str = "";
        string letter = "";

        long input;
        long result = 0;

        Console.Title = "Decimal to Hexadecimal";

        Console.WriteLine("This program converts an integer number to its hexadecimal representation.");
        Console.WriteLine("*** NOTE: This program reads decimal integer numbers of size up to 64 bits\n");

        try
        {
            Console.Write("Enter the decimal integer number: ");
            input = Int64.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Dec number: {0}", input);

            if (input == 0)
            {
                Console.WriteLine("Hex number: 0\n");
            }

            else if (input > 0)
            {
                while (input > 0)
                {
                    result = input % 16;

                    switch (result)
                    {
                        case 15: letter = "F"; break;
                        case 14: letter = "E"; break;
                        case 13: letter = "D"; break;
                        case 12: letter = "C"; break;
                        case 11: letter = "B"; break;
                        case 10: letter = "A"; break;
                        case 9: letter = "9"; break;
                        case 8: letter = "8"; break;
                        case 7: letter = "7"; break;
                        case 6: letter = "6"; break;
                        case 5: letter = "5"; break;
                        case 4: letter = "4"; break;
                        case 3: letter = "3"; break;
                        case 2: letter = "2"; break;
                        case 1: letter = "1"; break;
                        case 0: letter = "0"; break;
                    }

                    input = input / 16;
                    str = str + letter;
                }

                hex = string.Join(string.Empty, str.Reverse());
                Console.WriteLine("Hex number: {0}\n", hex);

            }
            else if (input < 0)
            {
                input = Int64.MinValue - (input);

                while (input < 0)
                {
                    result = input % 16;

                    switch (result)
                    {
                        case -15: letter = "F"; break;
                        case -14: letter = "E"; break;
                        case -13: letter = "D"; break;
                        case -12: letter = "C"; break;
                        case -11: letter = "B"; break;
                        case -10: letter = "A"; break;
                        case -9: letter = "9"; break;
                        case -8: letter = "8"; break;
                        case -7: letter = "7"; break;
                        case -6: letter = "6"; break;
                        case -5: letter = "5"; break;
                        case -4: letter = "4"; break;
                        case -3: letter = "3"; break;
                        case -2: letter = "2"; break;
                        case -1: letter = "1"; break;
                        case -0: letter = "0"; break;
                    }

                    input = input / 16;
                    str = str + letter;
                }

                hex = string.Join(string.Empty, str.Reverse());
                Console.WriteLine("Hex number: {0}", hex);
                
            }
        }

        catch (OverflowException)
        {
            Console.WriteLine();
            Console.WriteLine("The decimal number is out of its bit range.");
            Console.WriteLine("The decimal number must be of 64 bit size!\n");            
        }
        catch (FormatException)
        {
            Console.WriteLine();
            Console.WriteLine("Invalid input!\n");
        }
    }
}

