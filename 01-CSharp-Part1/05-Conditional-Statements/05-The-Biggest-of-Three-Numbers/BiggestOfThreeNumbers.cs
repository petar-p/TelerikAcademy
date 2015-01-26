using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        /*
         *  Problem 5: The Biggest of 3 Numbers
         * 
         *  - Write a program that finds the biggest of three numbers.
         * 
         * */

        double firstNum;
        double secondNum;
        double thirdNum;

        Console.Title = "The Biggest of 3 Numbers";

        Console.WriteLine("The program reads 3 numbers and prints the biggest one of them.\n");

        // Input
        Console.Write("Enter the 1st number: ");
        firstNum = Double.Parse(Console.ReadLine());

        Console.Write("Enter the 2nd number: ");
        secondNum = Double.Parse(Console.ReadLine());

        Console.Write("Enter the 3rd number: ");
        thirdNum = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        // Logic

        if ((firstNum >= secondNum) && (firstNum >= thirdNum))                // Case1: Biggest number is the first number.
        {
            Console.WriteLine("The biggest number is: {0}\n", firstNum);
        }
        else if ((secondNum >= firstNum) && (secondNum >= thirdNum))          // Case2: Biggest number is the second number.
        {
            Console.WriteLine("The biggest number is: {0}\n", secondNum);
        }
        else                                                                  // Case3: Biggest number is the third number.
        {
            Console.WriteLine("The biggest number is: {0}\n", thirdNum);
        }
    }
}