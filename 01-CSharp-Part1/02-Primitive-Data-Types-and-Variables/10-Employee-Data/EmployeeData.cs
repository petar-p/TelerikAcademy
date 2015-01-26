using System;

class EmployeeData
{
    static void Main()
    {
        /*
         *  Problem 10: Employee Data
         *  
         *  - A marketing company wants to keep record of its employees. Each record would have the following characteristics:
         *  
         *      - First name
         *      - Last name
         *      - Age (0...100)
         *      - Gender (m or f)
         *      - Personal ID number (e.g. 8306112507)
         *      - Unique employee number (27560000…27569999)
         *      
         *  - Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
         *  
         *  - Use descriptive names. Print the data at the console. 
         * 
         * */

        string firstName = "John";
        string lastName = "Doe";
        byte age = 30;
        char gender = 'M';
        long persID = 8306112507;
        int emplNum = 27560000;

        string spacer = " ";

        Console.Title = "Employee data";

        Console.WriteLine("{0}Employee data:", spacer);
        Console.WriteLine();

        Console.WriteLine("{0,5}First name: {1}\n{2,6}Last name: {3}\n{4,12}Age: {5}\n{6,9}Gender: {7}\n{8,4}Personal ID: {9}\nEmployee number: {10}",
                            spacer, firstName, spacer, lastName, spacer, age, spacer, gender, spacer, persID, emplNum);

        Console.WriteLine();
    }
}
