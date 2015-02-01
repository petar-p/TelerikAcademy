using System;

class OddAndEvenProduct
{
    static void Main()
    {
        /*
         *  Problem 10: Odd and Even Product
         *  
         *  - You are given n integers (given in a single line, separated by a space).
         *  
         *  - Write a program that checks whether the product of the odd elemen.
         *  ts is equal to the product of the even elements.
         *  
         *  - Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
         * 
         * */

        Console.Title = "Odd and Even Product";

        Console.WriteLine("This program reads from the console 'n' integers (given in a single line, \nseparated by a space) and checks whether the product of the odd elements \nis equal to the product of the even elements. Note that elements are counted \nfrom 1 to 'n', so the the first element is odd, and the second is even.");
        Console.WriteLine();

        Console.WriteLine("Enter the 'n' integers:\n");

        string input = Console.ReadLine();
        string[] array = input.Split(' ');
        int oddProduct = 1;
        int evenProduct = 1;

        for (int index = 0; index < array.Length; index++)
        {
            int number = int.Parse(array[index]);
            if (index % 2 == 0 || index == 0)
            {
                oddProduct *= number;
            }
            else
            {
                evenProduct *= number;
            }
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}\n", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd procuct = {0}", oddProduct);
            Console.WriteLine("even procuct = {0}\n", evenProduct);
        } 
    }
}