using System;

class ExchangeIfGreater
{
    static void Main()
    {
        /*
         *  Problem 1: Exchange If Greater
         *  
         *  - Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
         *    As a result print the values a and b, separated by a space.
         * 
         * */

        double varA;
        double varB;
        double varTemp;

        Console.Title = "Exchange if greater";

        Console.WriteLine("The program reads 2 variables A and B, and exchanges their values ");
        Console.WriteLine("if the first one is greater than the second one.\n");

        bool greaterAB;

        Console.Write("Enter the first variable: ");
        varA = Double.Parse(Console.ReadLine());

        Console.Write("Enter the second varialbe: ");
        varB = Double.Parse(Console.ReadLine());

        greaterAB = varA > varB;

        if (greaterAB)
        {
            varTemp = varA;
            varA = varB;
            varB = varTemp;
            Console.WriteLine("{0} {1}\n", varA, varB);
        }
        else
        {
            Console.WriteLine("{0} {1}\n", varA, varB);    
        }  
    }
}