using System;

class QuadraticEquation
{
    static void Main()
    {
        /*
         *  Problem 6: Quadratic equation
         *  
         *  - Write a program that reads the parameters a, b and c of a quadratic equation ax2 + bx + c = 0, solves it and prints its real roots.
         * 
         * */

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // This program solves a quadratic equation

        // Declaring variables
        double a;       // Parameter 'a'
        double b;       // Parameter 'b'
        double c;       // Parameter 'c'
        double d;       // Discriminant
        double root0;   // Root if Discriminant = 0
        double root1;   // Root 1 if Discriminant > 0
        double root2;   // Root 2 if Discriminant > 0
        
        // Notes on program's purpose
        Console.Title = "Quadratic equation";
        Console.WriteLine("This program solves a quadratic equation ax\xB2 + bx + c = 0");
        Console.WriteLine();

        // Read parameter 'a'
        Console.Write("Enter parameter a: ");
        a = double.Parse(Console.ReadLine());

            if (a == 0)                                     // Case: a = 0 --> No solution. 
            {
                Console.WriteLine();
                Console.WriteLine("The equation has no solution!\n");
            }

            else                                            // Equation solution 
            {
                Console.Write("Enter parameter b: ");
                b = double.Parse(Console.ReadLine());       // Read parameter 'b' 

                Console.Write("Enter parameter c: ");
                c = double.Parse(Console.ReadLine());       // Read parameter 'c' 

                d = (b * b) - (4 * a * c);                  // Calculating Discriminant 

                Console.WriteLine();
                Console.WriteLine("Soluton:\n");            

                    if (d < 0)                                  // Case 1: Discriminant < 0 
                    {
                        Console.WriteLine("The equation has no real roots!\n");               
                    }

                    else if (d == 0)                            // Case 2: Discriminant = 0 
                    {
                        root0 = (-b) / (2 * a);
                        Console.WriteLine("The equation has 1 real root!");
                        Console.WriteLine("x = {0:f2}\n", root0);
                    }

                    else                                        // Case 3: Discriminant > 0 
                    {
                        root1 = ((-b) + Math.Sqrt(d)) / (2 * a);
                        root2 = ((-b) - Math.Sqrt(d)) / (2 * a);

                        Console.WriteLine("The equation has 2 real roots!");
                        Console.WriteLine("x\u2081 = {0:f2}", root1);
                        Console.WriteLine("x\u2082 = {0:f2}\n", root2);                
                    }
            }
    }
}