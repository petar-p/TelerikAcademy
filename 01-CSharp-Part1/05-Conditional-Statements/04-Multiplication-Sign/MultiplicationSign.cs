using System;

class MultiplicationSign
{
    static void Main()
    {
        /*
         *  Problem 4: Multiplication sign
         *  
         *  - Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
         *  
         *  - Use a sequence of if operators.
         * 
         * */

        double firstNum;
        double secondNum;
        double thirdNum;

        Console.Title = "Miltiplication sign";

        Console.WriteLine("The program shows the sign (+. - or 0) of the product of three real numbers, \nwithout calculating it.\n");

        // Input
        Console.Write("Enter the 1st number: ");
        firstNum = Double.Parse(Console.ReadLine());

        Console.Write("Enter the 2nd number: ");
        secondNum = Double.Parse(Console.ReadLine());

        Console.Write("Enter the 3rd number: ");
        thirdNum = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        // Program logic

        if ((firstNum == 0) || (secondNum == 0) || (thirdNum == 0))     // Case1: If any number is 0 
        {
            Console.WriteLine("The Sign is: 0\n");
        }
        else
        {
            if ((firstNum > 0 && secondNum > 0 && thirdNum > 0) ||      // Case2: Positive sign 
                (firstNum > 0 && secondNum < 0 && thirdNum < 0) ||
                (firstNum < 0 && secondNum < 0 && thirdNum > 0))
            {
                Console.WriteLine("The Sign is: +\n");
            }
            else                                                        // Case3: In all other cases the sign is negative
            {
                Console.WriteLine("The Sign is: -\n");    
            }            
        }
    }
}
