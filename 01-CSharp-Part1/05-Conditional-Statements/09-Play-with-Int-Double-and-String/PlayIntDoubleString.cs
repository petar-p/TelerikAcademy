using System;

class PlayIntDoubleString
{
    static void Main()
    {
        /*
         *  Problem 9: Play with Int, Double, and String
         * 
         *  - Write a program that, depending on the user’s choice, inputs an int, double or string variable.
         *  
         *  - If the variable is int or double, the program increases it by one.
         *  
         *  - If the variable is a string, the program appends * at the end.
         *  
         *  - Print the result at the console. Use switch statement.
         * 
         * */

        int input;
        int integerType;
        double doubleType;
        string stringType;

        Console.Title = "Play with Int, Double and String";

        Console.WriteLine("Make a choice: (1)-Integer; (2)-Double; (3)-String\n");

        Console.Write("Your choice: ");
        input = Int32.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (input)
        {
            case 1: 
                Console.Write("Enter an integer: ");
                integerType = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                integerType++;
                Console.WriteLine("Result: {0}\n", integerType);
                break;
            case 2:
                Console.Write("Enter a double: ");
                doubleType = Double.Parse(Console.ReadLine());
                Console.WriteLine();
                doubleType++;
                Console.WriteLine("Result: {0}\n", doubleType);
                break;
            case 3:
                Console.Write("Enter a string: ");
                stringType = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Result: {0}*\n", stringType);
                break;
            default:
                Console.WriteLine("Invalid choice!\n");
                break;
        }
    }
}