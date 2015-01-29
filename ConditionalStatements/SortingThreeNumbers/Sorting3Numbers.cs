//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

using System;
using System.Threading;
using System.Globalization; //To ensure the decimal separator is "." not ","
class Sorting3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter a=");
        string aString = Console.ReadLine();
        aString = aString.Replace(",", ".");
        double a = double.Parse(aString);

        Console.Write("Enter b=");
        string bString = Console.ReadLine();
        bString = bString.Replace(",", ".");
        double b = double.Parse(bString);

        Console.Write("Enter c=");
        string cString = Console.ReadLine();
        cString = cString.Replace(",", ".");
        double c = double.Parse(cString);
        if (a > b)
        {
            if (a > c)
            {
                if (b>c)
                {
                   Console.WriteLine("{0},{1},{2}", a, b, c); 
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", a,c, b);
                }
            }
            else
            {
                Console.WriteLine("{0},{1},{2}", c, a, b);
            }
        }
        else
        {
            if (b > c)
            {
                if (a>c)
                {
                    Console.WriteLine("{0},{1},{2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", b, c, a);
                }
            }
            else
            {
                Console.WriteLine("{0},{1},{2}", c, b, a);
            }
        }
    }
}
