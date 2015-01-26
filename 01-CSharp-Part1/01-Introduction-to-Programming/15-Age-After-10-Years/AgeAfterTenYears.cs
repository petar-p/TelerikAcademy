using System;
using System.Globalization;

class AgeAfterTenYears
{
    static void Main()
    {
        /*
         *  Problem 15: Age after 10 years
         *  
         *  - Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
         *  
         * */

        CultureInfo cultureinfo = new CultureInfo("en-US");     // Setting default current culture 

        Console.Title = "Age after 10 years";

        // Input: 
        Console.WriteLine("This program reads your birthday and prints how old you will be after 10 years.");
        Console.WriteLine("Enter your birthday");
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Month: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Day: ");
        int day = int.Parse(Console.ReadLine());

        // Declaring date1(bithdate) and date2(today's date) 
        DateTime date1 = new DateTime(year, month, day);
        DateTime date2 = DateTime.Today;

        // Date 2 - Date1 results all days 
        TimeSpan diff1 = date2.Subtract(date1);

        int totalDays = (int)diff1.TotalDays;   // gets the total days form the subtraction 
        int years = totalDays / 365;            // calculates the years 
        int days = totalDays % 365;             // calculates the remainder days (This includes the days from leap years) 

        // Output: 
        Console.WriteLine();
        Console.WriteLine("You are {0} years and {1} days old, or otherwise exactly {2} days.", years, days, totalDays);
        Console.WriteLine("After 10 years you will be {0} years old.", (years + 10));
        Console.WriteLine();

    }
}