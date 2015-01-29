//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;
class CompanyInformation
{
    static void Main()
    {
        Console.Write("Company name:");
        string companyName = Console.ReadLine();
        Console.Write("Company address:");
        string companyAdress = Console.ReadLine();
        Console.Write("Phone number (without spaces):");
        long phoneNumber = long.Parse(Console.ReadLine());
        Console.Write("Fax number(without spaces):");
        long faxNumber = Int64.Parse(Console.ReadLine());
        Console.Write("Web site:");
        string webSite = Console.ReadLine();
        Console.Write("Manager first name:");
        string firstName = Console.ReadLine();
        Console.Write("Manager last name:");
        string lastName = Console.ReadLine();
        Console.Write("Manager age:");
        int age= Convert.ToInt32(Console.ReadLine());
        Console.Write("Manager phone:(without spaces):");
        long phoneManager = long.Parse(Console.ReadLine());
        Console.WriteLine(@"
                            Company name: {0,}
                            Company address: {1} 
                            Phone number: {2} 
                            Fax number: {3} 
                            Web site: {4} 
                            Manager first name: {5} 
                            Manager last name: {6} 
                            Manager age: {7} 
                            Manager phone: {8}",
        companyName,companyAdress,phoneNumber,faxNumber,webSite,firstName,lastName,age,phoneManager );
    }
}
