using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        /*
         *  Problem 3: Circle Perimeter and Area
         *  
         *  - Write a program that reads the radius r of a circle and prints its perimeter and 
         *    area formatted with 2 digits after the decimal point.
         * 
         * */

        double radius;
        double perimeter;
        double area;

        Console.Title = "Circle Perimeter and Area";

        Console.WriteLine("The program reads the radius r of a circle and prints its perimeter and area.\n");

        Console.Write("Enter the radius: ");
        radius = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        perimeter = 2 * radius * Math.PI;
        area = Math.PI * radius * radius;

        Console.WriteLine("Circle perimeter: {0:f2}", perimeter);
        Console.WriteLine("Circle area: {0:f2}\n", area);
    }
}