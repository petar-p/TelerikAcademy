using System;

class BankAccount
{
    static void Main()
    {
        /*
         *  Problem 11: Bank Account Data
         *  
         *  - A bank account has a holder name (first name, middle name and last name), 
         *    available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
         *    
         *  - Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
         * 
         * */

        string firstName = "John";
        string middleName = "Smith";
        string lastName = "Doe";

        decimal balance = 145863.85m;
        string bankName = "Raiffeisenbank";
        string iBAN = "DE10 1009 0044 0532 0130 18";
        long creditCard1 = 4000000000123456;
        long creditCard2 = 4000000000789012;
        long creditCard3 = 4000000000345678;

        string spacer = " ";

        Console.Title = "Bank Account Data";

        Console.WriteLine("Bank Account Data:\n");        

        Console.WriteLine("{0,3}First name: {1}\n{2,2}Middle name: {3}\n{4,4}Last name: {5}\n", 
                            spacer, firstName, spacer, middleName, spacer, lastName);
        
        Console.WriteLine("{0,6}Balance: {1}\n{2,4}Bank name: {3}\n{4,9}IBAN: {5}\n",
                            spacer, balance, spacer, bankName, spacer, iBAN);

        Console.WriteLine("Credit Card 1: {0}\nCredit Card 2: {1}\nCredit Card 3: {2}\n",
                           creditCard1, creditCard2, creditCard3);       
    }
} 