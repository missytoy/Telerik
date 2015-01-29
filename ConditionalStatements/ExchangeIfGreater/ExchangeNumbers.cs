//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values
//if the first one is greater than the second one. As a result print the values a and b, separated by a space.

using System;
using System.Threading;
using System.Globalization; //To ensure the decimal separator is "." not ","

class ExchangeNumbers
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
        double helper;
        if (a > b)
        {
            helper = a;
            a = b;
            b = helper;
            Console.WriteLine("{0} {1}", a, b);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
