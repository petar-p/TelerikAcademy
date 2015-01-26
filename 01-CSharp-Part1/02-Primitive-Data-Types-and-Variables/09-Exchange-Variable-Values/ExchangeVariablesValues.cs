using System;

class ExchangeVariablesValues
{
    static void Main()
    {
        /*
         *  Problem 9: Exchange variable values
         *  
         *  - Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
         *  
         *  - Print the variable values before and after the exchange.
         * 
         * */

        int a = 5;
        int b = 10;
        int temp;       // using a third variable that will assist in the exchange.

        Console.Title = "Exchange variables values";

        Console.WriteLine("Variables before exchange:");
        Console.WriteLine();

        Console.WriteLine("Variable a = {0}", a);
        Console.WriteLine("Variable b = {0}", b);
        Console.WriteLine();

        temp = a;
        a = b;
        b = temp;

        Console.WriteLine("Variables after exchange:");
        Console.WriteLine();

        Console.WriteLine("Variable a = {0}", a);
        Console.WriteLine("Variable b = {0}", b);
        Console.WriteLine();
    }
}