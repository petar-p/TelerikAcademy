using System;

class NullValuesArithmetic
{
    static void Main()
    {
        /*
         *  Problem 12: Null Values Arithmetic
         *  
         *  - Create a program that assigns null values to an integer and to a double variable.
         *  
         *  - Try to print these variables at the console.
         *  
         *  - Try to add some number or the null literal to these variables and print the result.
         * 
         * */

        Nullable<int> firstValue = null;        // First way of declaring a nullable value type variable
        double? secondValue = null;             // Second way of declaring a nullable value type variable

        Console.Title = "Null Value Arithmetic";

        Console.WriteLine("Integer nullable value variable: {0}", firstValue);
        Console.WriteLine("Double nullable value variable: {0}\n", secondValue);

        firstValue = firstValue + 5;
        secondValue = secondValue + 5;

        Console.WriteLine("Result after adding 5 to both variables:\n");
        Console.WriteLine("Integer nullable value variable: {0}", firstValue);
        Console.WriteLine("Double nullable value variable: {0}\n", secondValue);
    }
}