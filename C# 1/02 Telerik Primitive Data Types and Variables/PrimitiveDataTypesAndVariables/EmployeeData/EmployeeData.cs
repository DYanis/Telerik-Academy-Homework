//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//
//    First name
//    Last name
//    Age (0...100)
//    Gender (m or f)
//    Personal ID number (e.g. 8306112507)
//    Unique employee number (27560000…27569999)
//
//Declare the variables needed to keep the information for a single employee
//using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "User";
        string lastName = "User";
        byte age = 29;
        string gender = "Man";
        long personalIDNumber = 8306112507;
        int uniqueEmployeeNumber = 27560000;
        
        Console.WriteLine("First Name is {0}\nLast Name is {1}", firstName, lastName);
        Console.WriteLine("Age = {0}\nGender = {1}\nPersonal ID Number = {2}\nUnique Employee Number = {3}",
            age, gender, personalIDNumber, uniqueEmployeeNumber);
    }
}

