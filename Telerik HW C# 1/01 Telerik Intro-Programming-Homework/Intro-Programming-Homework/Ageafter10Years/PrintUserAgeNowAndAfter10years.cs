//Write a program to read your birthday from the console and print how old you are now 
//and how old you will be after 10 years.

using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter your birhday:");
        DateTime birthDay = new DateTime();
        birthDay = DateTime.Parse(Console.ReadLine());
        System.TimeSpan myCurrentAge = new TimeSpan();
        myCurrentAge = (DateTime.Now - birthDay);      
        int age = (int)(myCurrentAge.Days / 365.2);
        
        Console.WriteLine("You are now {0} years old.", age);
        Console.WriteLine("Your age after ten years will be: " + (age+10));
    }
}

