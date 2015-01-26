using System;

class SortThreeNumbers
{
    static void Main()
    {
        /*
         *  Problem 7: Sort 3 Numbers with Nested Ifs
         *  
         *  - Write a program that enters 3 real numbers and prints them sorted in descending order.
         *  
         *  - Use nested if statements.
         *  
         *  - Note: Don’t use arrays and the built-in sorting functionality.
         * 
         * */

        double varA;
        double varB;
        double varC;

        Console.Title = "Sort 3 Numbers";

        Console.WriteLine("The program reads 3 real numbers and prints them sorted in descending order.\n");

        // Input
        Console.Write("Enter 1st number: ");
        varA = Double.Parse(Console.ReadLine());
        
        Console.Write("Enter 2nd number: ");
        varB = Double.Parse(Console.ReadLine());

        Console.Write("Enter 3rd number: ");
        varC = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        if ((varA >= varB) && (varA >= varC))               // Case1: The 1st number is the greatest
        {
            Console.Write("{0}, ", varA);
            if (varB >= varC)
            {
                 Console.Write("{0}, {1}\n", varB, varC);
            }
            else
            {
                Console.Write("{0}, {1}\n", varC, varB);
            }
        }

        if ((varB > varA) && (varB > varC))                 // Case2: The 2nd number is the greatest
        {
            Console.Write("{0}, ", varB);
            if (varA >= varC)
            {
                Console.Write("{0}, {1}\n", varA, varC);
            }
            else
            {
                Console.Write("{0}, {1}\n", varC, varA);
            }
        }

        if ((varC > varA) && (varC > varB))                 // Case3: The 3rd number is the greatest
        {
            Console.Write("{0}, ", varC);
            if (varA >= varB)
            {
                Console.Write("{0}, {1}\n", varA, varB);
            }
            else
            {
                Console.Write("{0}, {1}\n", varB, varA);
            }
        }
        Console.WriteLine();
    }
}
