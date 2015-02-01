using System;

class RandomizeOneToN
{
    static void Main()
    {
        /*
         *  Problem 12:* Randomize the Numbers 1…N
         *  
         *  - Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
         * 
         * */
        
        int inputN;
        int number;

        Random randNum = new Random();

        Console.Title = "Randomized numbers from 1 to N";

        Console.WriteLine("The program reads an integer n and prints the numbers 1, 2, … n in random order.");
        
        // Input
        Console.Write("Enter the number n: ");
        inputN = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        
        bool[] printed = new bool[inputN + 1]; // An array of bool values, all set to 'false' as default; size of array = n+1

        Console.WriteLine("Numbers from 1 to {0}, randomized:", inputN);

        for (int i = 1; i <= inputN; i++)
        {
            number = randNum.Next(1, inputN +1);    // Generating random number 

            if (!printed[number])   // If the bool value of bool[position is the generated random number] is false, THEN
            {
                Console.Write("{0}, ", number); // Print number
                printed[number] = true;         // Set the bool value of bool[generated random number] to true, so we skip this number next time.
                continue;                       // Continue to next iteration (next generated random number)
            }
            i--;        // ELSE, decrease counter so we don't hit the loop end, before all random numbers are printed.
        }
        
        Console.WriteLine();
        Console.WriteLine();
    }
}