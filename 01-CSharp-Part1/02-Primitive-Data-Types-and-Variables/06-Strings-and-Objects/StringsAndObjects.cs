﻿using System;

class StringsAndObjects
{
    static void Main()
    {
        /*
         *  Problem 6: Strings and Objects
         * 
         *  - Declare two string variables and assign them with Hello and World.
         *  
         *  - Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
         *  
         *  - Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
         *  
         * */

        string str1 = "Hello ";
        string str2 = "World!";

        object obj = str1 + str2;

        string str3 = (string)obj;

        Console.Title = "Strings and Objects";
        Console.WriteLine(str3);
        Console.WriteLine();
    }
}