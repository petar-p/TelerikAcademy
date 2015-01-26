using System;

class DigitAsWord
{
    static void Main()
    {
        /*
         *  Problem 8: Digit as Word
         *  
         *  - Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
         *  
         *  - Print “not a digit” in case of invalid input.
         *  
         *  - Use a switch statement.
         * 
         * */

        string input;

        Console.Title = "Digit as Word";

        Console.WriteLine("The program reads a digit (0-9) and shows it as a word (in English).\n");

        // Input
        Console.Write("Enter the digit: ");
        input = Console.ReadLine();
        Console.WriteLine();                

        switch (input)
        {
            case "0": Console.WriteLine("Zero.\n"); break;
            case "1": Console.WriteLine("One.\n"); break;
            case "2": Console.WriteLine("Two.\n"); break;
            case "3": Console.WriteLine("Three.\n"); break;
            case "4": Console.WriteLine("Four.\n"); break;
            case "5": Console.WriteLine("Five.\n"); break;
            case "6": Console.WriteLine("Six.\n"); break;
            case "7": Console.WriteLine("Seven.\n"); break;
            case "8": Console.WriteLine("Eight.\n"); break;
            case "9": Console.WriteLine("Nine.\n"); break;

            default:
                Console.WriteLine("Not a digit.\n"); break;
        }
    }
}
