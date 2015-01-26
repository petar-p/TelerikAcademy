using System;
using System.Globalization;

class ComparingFloats
{
    static void Main()
    {
        /*
         *  Problem 13*: Comparing floats
         *  
         *  - Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
         *  
         *  - Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.
         *          Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
         * 
         * */

        double a;
        double b;
        double eps = 0.000001;

        Console.Title = "Comparing Floats"; 

        Console.Write("Enter 1st floating point number: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Enter 2nd floating point number: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine();       

        double diff = Math.Abs(a - b);       
        
        if (diff == eps)
        {
            Console.WriteLine("They are equal.\n");
        }
        else if (diff > eps)
        {
            Console.WriteLine("The difference is bigger than eps = 0.000001\n");
        }
        else if (diff < eps)
        {
            Console.WriteLine("The difference is less than eps = 0.000001\n");
        }
    }
}

