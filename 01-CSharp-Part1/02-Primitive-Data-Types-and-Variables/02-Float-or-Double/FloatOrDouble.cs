using System;

class FloatOrDouble
{
    static void Main()
    {
        /*
         *  Problem 2: Float or Double
         * 
         *  - Which of the following values can be assigned to a variable of type float 
         *    and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091 ?
         *    
         *  - Write a program to assign the numbers in variables and print them to ensure no precision is lost.
         * 
         * */

        // Float supports 7 digits, regardless before or after the decimal point.   Example: xxxx.xxx or xx.xxxxx, etc.
        // Double supports 15 digits, regardless before or after the decimal point. Example: xxxxx.xxxxxxxxxx or xxxxxxxxxx.xxxxx, etc.

        double var1 = 34.567839023;
        float var2 = 12.345f;           // always suffix 'f' after float type. 
        double var3 = 8923.1234857f;
        float var4 = 3456.091f;

        Console.Title = "Float or Double";

        Console.WriteLine("Using Float or Double:");
        Console.WriteLine();

        Console.WriteLine("{0,15}: used variable type 'double'", var1);
        Console.WriteLine("{0,15}: used variable type 'float'", var2);
        Console.WriteLine("{0,15}: used variable type 'double'", var3);
        Console.WriteLine("{0,15}: used variable type 'float'", var4);
        Console.WriteLine();
    }
}