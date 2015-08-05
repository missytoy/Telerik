//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
using System.Threading;
using System.Globalization;

class SumNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //To ensure that we use "." instead of ","

        Console.Write("Enter fist number (a):");
        string str = Console.ReadLine();
        str = str.Replace(",", ".");
        double a = double.Parse(str);

        Console.Write("Enter second number (b):");
        str = Console.ReadLine();
        str = str.Replace(",", ".");
        double b = double.Parse(str);

        Console.Write("Enter third number (c):");
        str = Console.ReadLine();
        str = str.Replace(",", ".");
        double c = double.Parse(str);

        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);

    }
}

