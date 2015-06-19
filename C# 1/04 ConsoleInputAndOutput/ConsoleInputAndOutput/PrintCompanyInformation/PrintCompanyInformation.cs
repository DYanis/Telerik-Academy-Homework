// A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Please enter Company name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Please enter Company address: ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Please enter Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Please enter Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.WriteLine("Please enter Web site: ");
        string webSite = Console.ReadLine();
        Console.WriteLine("Please enter Manager first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Please enter Manager last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Please enter Manager age: ");
        string age = Console.ReadLine();
        Console.WriteLine("Please enter Manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("     {0} \n address: {1} \n phone number: {2} \n fax number: {3} \n web site: {4} \n first name: {5} \n last name: {6} \n age: {7} \n manager phone: {8} \n\n\n ", companyName, companyAddress, phoneNumber, faxNumber, webSite, firstName, lastName, age, managerPhone);
    }
}

