using System;

class PrintCompanyInformation
{
    static void Main()
    {
        /*
         *  Problem 2: Print Company Information
         * 
         *  - A company has name, address, phone number, fax number, web site and manager. 
         *    The manager has first name, last name, age and a phone number.
         *    
         *  - Write a program that reads the information about a company and its manager and prints it back on the console.
         *  
         * */

        string companyName = "Company name:";
        string companyAddress = "Company address:";        
        string webSite = "Website:";
        string manFstName = "Manager first name:";
        string manLstName = "Manager last name:";
        string phoneNum = "Phone number:";
        string faxNum = "Fax number:";
        string manAge = "Manager age:";
        string manPhone = "Manager phone:";

        string companyNameOutput;
        string companyAddressOutput;        
        string webSiteOutput;
        string manFstNameOutput;
        string manLstNameOutput;
        long phoneNumOutput;
        int faxNumOutput;
        int manAgeOutput;
        long manPhoneOutput;

        Console.Title = "Company Information";

        // Input
        Console.Write("{0} ",companyName);
        companyNameOutput = Console.ReadLine();

        Console.Write("{0} ",companyAddress);
        companyAddressOutput = Console.ReadLine();

        Console.Write("{0} ", phoneNum);
        phoneNumOutput = Int64.Parse(Console.ReadLine());

        Console.Write("{0} ", faxNum);
        faxNumOutput = Int32.Parse(Console.ReadLine());

        Console.Write("{0} ", webSite);
        webSiteOutput = Console.ReadLine();

        Console.Write("{0} ", manFstName);
        manFstNameOutput = Console.ReadLine();

        Console.Write("{0} ", manLstName);
        manLstNameOutput = Console.ReadLine();

        Console.Write("{0} ", manAge);
        manAgeOutput = Int32.Parse(Console.ReadLine());

        Console.Write("{0} ", manPhone);
        manPhoneOutput = Int64.Parse(Console.ReadLine());
        Console.WriteLine();

        // Output
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Company information\n");

        Console.WriteLine("{0,19} {1}", companyName, companyNameOutput);
        Console.WriteLine("{0,19} {1}", companyAddress, companyAddressOutput);
        Console.WriteLine("{0,19} +{1:### ### ## ## ###}", phoneNum, phoneNumOutput);
        Console.WriteLine("{0,19} {1}", faxNum, faxNumOutput);
        Console.WriteLine("{0,19} {1}", webSite, webSiteOutput);
        Console.WriteLine("{0} {1}", manFstName, manFstNameOutput);
        Console.WriteLine("{0,19} {1}", manLstName, manLstNameOutput);
        Console.WriteLine("{0,19} {1}", manAge, manAgeOutput);
        Console.WriteLine("{0,19} +{1:### # ### ###}", manPhone, manPhoneOutput);

        Console.WriteLine();
    }
}