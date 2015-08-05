//Problem 10.* Beer Time

//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute 
//in range [00…59]and AM/PM designator) and prints beer time or non-beer time according to the definition 
//above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

using System;
using System.IO;
using System.Globalization;
class DateAndTime
{
    static void Main()
    {
        Console.WriteLine(@"Enter time in format ""hh:mm tt""
(an hour in range [01...12], a minute in range [00…59]and AM/PM designator):");
        var timeChek = DateTime.Parse(Console.ReadLine());


        TimeSpan timespan1 = new TimeSpan(03, 00, 00);
        DateTime time1 = DateTime.Today.Add(timespan1);

        TimeSpan timespan2 = new TimeSpan(13, 00, 00);
        DateTime time2 = DateTime.Today.Add(timespan2);

        if (timeChek.TimeOfDay < time1.TimeOfDay || timeChek.TimeOfDay >= time2.TimeOfDay)
        {
            Console.WriteLine("Beer time!");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}

