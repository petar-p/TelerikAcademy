using System;

class Rectangles
{
    static void Main()
    {
        /*
         *  Priblem 4: Rectangles
         *  
         *  - Write an expression that calculates rectangle’s perimeter and area by given width and height.
         * 
         * */

        double width;
        double height;
        double perimeter;
        double area;

        Console.Title = "Rectangles";

        Console.WriteLine("The program calculates rectangle’s perimeter and area by given width and height.");

        Console.Write("Enter width: ");
        width = Double.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        height = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        perimeter = 2 * (width + height);
        area = width * height;

        Console.WriteLine("Perimeter: {0:f2}", perimeter);
        Console.WriteLine("Area: {0:f2}\n", area);
    }
}