using System;

class BiggestOfFiveNumbers
{
    static void Main()
    {
        /*
         *  Problem 6: The Biggest of 5 Numbers
         *  
         *  - Write a program that finds the biggest of five numbers by using only five if statements.
         * 
         * */

        double firstNum;
        double secondNum;
        double thirdNum;
        double fourthNum;
        double fifthNum;

        Console.Title = "The Biggest of 5 Numbers";

        Console.WriteLine("The program reads 5 numbers and prints the biggest one of them.\n");

        // Input
        Console.Write("Enter the 1st number: ");
        firstNum = Double.Parse(Console.ReadLine());

        Console.Write("Enter the 2nd number: ");
        secondNum = Double.Parse(Console.ReadLine());

        Console.Write("Enter the 3rd number: ");
        thirdNum = Double.Parse(Console.ReadLine());

        Console.Write("Enter the 4th number: ");
        fourthNum = Double.Parse(Console.ReadLine());

        Console.Write("Enter the 5th number: ");
        fifthNum = Double.Parse(Console.ReadLine());
        Console.WriteLine();
        
        // Logic

        if ((firstNum >= secondNum) && (firstNum >= thirdNum) &&
           (firstNum >= fourthNum) && (firstNum >= fifthNum))                // Case1: Biggest number is the first number.
        {
            Console.WriteLine("The biggest number is: {0}\n", firstNum);
        }
        else if ((secondNum >= firstNum) && (secondNum >= thirdNum) &&
                (secondNum >= fourthNum) && (secondNum >= fifthNum))         // Case2: Biggest number is the second number.
        {
            Console.WriteLine("The biggest number is: {0}\n", secondNum);
        }
        else if ((thirdNum >= firstNum) && (thirdNum >= secondNum) &&
                (thirdNum >= fourthNum) && (thirdNum >= fifthNum))           // Case3: Biggest number is the third number.
        {
            Console.WriteLine("The biggest number is: {0}\n", thirdNum);
        }
        else if ((fourthNum >= firstNum) && (fourthNum >= secondNum) &&
                (fourthNum >= thirdNum) && (fourthNum >= fifthNum))          // Case4: Biggest number is the fourth number.
        {
            Console.WriteLine("The biggest number is: {0}\n", fourthNum);
        }
        else
        {
            Console.WriteLine("The biggest number is: {0}\n", fifthNum);     // Case5: Biggest number is the fifth number.
        }
    }
}