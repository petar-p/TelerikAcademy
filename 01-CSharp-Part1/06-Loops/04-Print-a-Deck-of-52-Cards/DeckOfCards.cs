using System;
using System.Text;

class DeckOfCards
{
    static void Main()
    {
        /*
         *  Problem 4: Print a Deck of 52 Cards
         *  
         *  - Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
         *  
         *  - The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
         *  
         *  - The card faces should start from 2 to A.
         *  
         *  - Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
         * 
         * */

        char spades = '\u2660';
        char hearts = '\u2665';
        char diamonds = '\u2666';
        char clubs = '\u2663';

        Console.Title = "Deck of Cards";

        Console.WriteLine("The program prints a standart deck of cards.\n");

        for (int i = 0; i < 12; i++)                        // Outer loop for card faces
        {
            for (int j = 0; j < 4; j++)                     // Inner loop for card suits
            {
                switch (i)                                  // Switch case detecting card face
                {
                    case 0: Console.Write(" 2"); break;     
                    case 1: Console.Write(" 3"); break;
                    case 2: Console.Write(" 4"); break;
                    case 3: Console.Write(" 5"); break;
                    case 4: Console.Write(" 6"); break;
                    case 5: Console.Write(" 7"); break;
                    case 6: Console.Write(" 8"); break;
                    case 7: Console.Write(" 9"); break;
                    case 8: Console.Write("10"); break;
                    case 9: Console.Write(" J"); break;
                    case 10: Console.Write(" Q"); break;
                    case 11: Console.Write(" K"); break;
                    case 12: Console.Write(" A"); break;
                }

                switch (j)                                  // Switch case detecting card suits
                {
                    case 0: Console.Write("{0}, ", spades); break;
                    case 1: Console.Write("{0}, ", hearts); break;
                    case 2: Console.Write("{0}, ", diamonds); break;
                    case 3: Console.Write("{0}, ", clubs); break;                    
                }
            }            
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}