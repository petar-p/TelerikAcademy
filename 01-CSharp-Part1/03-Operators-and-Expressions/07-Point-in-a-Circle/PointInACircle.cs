using System;

class PointInACircle
{
    static void Main()
    {
        /*
         *  Problem  7: Point in a Circle
         * 
         *  - Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
         * 
         * */

        Console.Title = "Point in a circle";
        Console.WriteLine("The program checks if given point (x, y) is inside a circle K({0, 0}, 2)\n");

        Console.Write("Enter the X coordinate: ");
        double inputX = Double.Parse(Console.ReadLine());

        Console.Write("Enter the Y coordinate: ");
        double inputY = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        decimal radius = 2;

        bool inCircle;

        /*  The point makes a right triangle with the center of the coordinate system.
         *  By calculating the hypotenuse of that triangle and comparing it to the circle's radius,
         *  we determine whether our point is inside or outside the circle.
         * */

        decimal hypotenuse = (decimal)Math.Sqrt(((inputX * inputX) + (inputY * inputY)));

        inCircle = (hypotenuse <= radius);

        Console.WriteLine(inCircle ? "The point is in the circle.\n" : "The point is outside the circle.\n");        
    }
}