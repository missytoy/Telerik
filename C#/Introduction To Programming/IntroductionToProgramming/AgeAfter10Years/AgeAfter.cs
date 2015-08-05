//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now
//and how old you will be after 10 years.

using System;
class AgeAfter
{
    static void Main()
    {
        Console.Write("Enter your birthday in format (DD.MM.YYYY):");
        var birthday = DateTime.Parse(Console.ReadLine());
        if (birthday > DateTime.Today) 
            Console.Write("Wrong year ! \n");
        else
        {
            int age = DateTime.Today.Year - birthday.Year;
            if (birthday.AddYears(age) > DateTime.Today) age--;
            Console.WriteLine("You are now {0} years old.\nYou will be {1} years old in 10 years.", age, age + 10);
        }
    }
}


