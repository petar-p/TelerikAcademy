using System;

class Trapezoids
{
    static void Main()
    {
        /*
         *  Problem 9: Trapezoids
         *  
         *  - Write an expression that calculates trapezoid's area by given sides a and b and height h.
         * 
         * */

        double baseA;
        double baseB;
        double height;
        double area;

        Console.Title = "Trapezoids";

        Console.WriteLine("The program calculates a trapezoid's area by given sides a and b and height h.\n");

        Console.Write("Enter the base a: ");
        baseA = Double.Parse(Console.ReadLine());

        Console.Write("Enter the base b: ");
        baseB = Double.Parse(Console.ReadLine());

        Console.Write("Enter the height h: ");
        height = Double.Parse(Console.ReadLine());

        Console.WriteLine();
        area = ((baseA + baseB) / 2) * height;

        Console.WriteLine("The area is: {0:f2}\n", area);
    }
}