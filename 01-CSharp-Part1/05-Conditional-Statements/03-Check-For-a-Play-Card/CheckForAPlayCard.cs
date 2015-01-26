using System;

class CheckForAPlayCard
{
    static void Main()
    {
        /*
         *  Problem 3: Check for a play card
         *  
         *  - Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
         *  
         *  - Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.
         *  
         * */

        string cardFace;

        Console.Title = "Check for a Play card";

        Console.WriteLine("Classical play cards use the following signs to designate the card face:\n2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.");
        Console.WriteLine("The program reads a string and and as a result tells \nif the entered string is a card face or no.\n");

        Console.Write("Enter card face: ");
        cardFace = Console.ReadLine();
        Console.WriteLine();

        switch (cardFace)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":                                                
            case "Q":
            case "K":
            case "A":
                Console.WriteLine("Yes.\n");
                break;
            default:
                Console.WriteLine("No.\n");
                break;
        }
    }
}