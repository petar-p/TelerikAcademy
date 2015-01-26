using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        /*
         *  Problem 2: Gravitation on the Moon
         *  
         *  - The gravitational field of the Moon is approximately 17% of that on the Earth.
         *  
         *  - Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
         * 
         * */

        double weightOnEarth;
        double weightOnMoon;

        Console.Title = "Gravitation on the Moon";

        Console.WriteLine("This program calculates the approximate weight of a man on the Moon.\n");
        Console.Write("What is the weight of the man on the Earth? : ");
        weightOnEarth = Double.Parse(Console.ReadLine());
        Console.WriteLine();

        weightOnMoon = weightOnEarth * 0.17;

        Console.WriteLine("The weight of the man on the Moon would be: {0:f2}\n", weightOnMoon);
    }
}