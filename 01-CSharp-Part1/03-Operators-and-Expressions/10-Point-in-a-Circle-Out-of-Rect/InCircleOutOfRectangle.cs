using System;

class InCircleOutOfRectangle
{
    static void Main()
    {
        /*
         *  Problem 10: Point Inside a Circle & Outside of a Rectangle
         *  
         *  - Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
         *    and out of the rectangle R(top=1, left=-1, width=6, height=2).
         * 
         * */

        double pointX;
        double pointY;
        double pointNx;     // coordinate of point Nx as if the center of the circle was the center of the coordinate system.
        double pointNy;     // coordinate of point Ny as if the center of the circle was the center of the coordinate system.

        decimal hypotenuse;
        decimal radius = 1.5m;        

        bool inCircle;
        bool inRect;
        bool result;

        Console.Title = "Point Inside a Circle & Outside of a Rectangle";

        Console.WriteLine("The program checks if a given point (x, y) is within the circle K({1, 1}, 1.5)");
        Console.WriteLine("and out of the rectangle R(top=1, left=-1, width=6, height=2).\n");

        // Input
        Console.Write("Enter coordinate X: ");
        pointX = Double.Parse(Console.ReadLine());

        Console.Write("Enter coordinate Y: ");
        pointY = Double.Parse(Console.ReadLine());
        Console.WriteLine();
        
        pointNx = pointX - 1;
        pointNy = pointY - 1;
        
        hypotenuse = (decimal)Math.Sqrt((pointNx * pointNx) + (pointNy * pointNy));
        
        inCircle = (hypotenuse <= radius) ? true : false;
        inRect = ((pointX >= -1) && (pointX <= 5)) && ((pointY >= -1) && (pointY <= 1));

        result = inCircle && (!inRect);

        Console.WriteLine("Is the point inside the circle and outside the rectangle ? - {0}!\n", result);
    }
}

