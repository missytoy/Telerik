//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;
using System.Threading;
using System.Globalization;

class Circle
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //To ensure the decimal separator is "." not ","
        string aString, bString;
        double a, b;

        Console.Write("Enter first number (a):");
        aString = Console.ReadLine();
        aString = aString.Replace(",", ".");
        a = Convert.ToDouble(aString);

        Console.Write("Enter second number (b):");
        bString = Console.ReadLine();
        bString = bString.Replace(",", ".");
        b = Convert.ToDouble(bString);

        double max = Math.Max(a, b);
        Console.WriteLine("The greater number is "+max);

    }
}

