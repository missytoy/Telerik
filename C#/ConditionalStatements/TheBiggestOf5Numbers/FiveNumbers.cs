//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

using System;
using System.Threading;
using System.Globalization; //To ensure the decimal separator is "." not ","
class FiveNumbers
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

        Console.Write("Enter d=");
        string dString = Console.ReadLine();
        dString = dString.Replace(",", ".");
        double d = double.Parse(dString);

        Console.Write("Enter e=");
        string eString = Console.ReadLine();
        eString = eString.Replace(",", ".");
        double e = double.Parse(eString);

        if (a > b && a > c && a > d && a > e)//first if statement.
        {
            Console.WriteLine("The biggest number is " + a);
        }
        else if (b > a && b > c && b > d && b > e)//2nd if statement.
        {
            Console.WriteLine("The biggest number is " + b);
        }
        else if (c > a && c > b && c > d && c > e)//3th  if statement.
        {
            Console.WriteLine("The biggest number is " + c);
        }

        else if (d > a && d > b && d > c && d > e)//4th if statement.
        {
            Console.WriteLine("The biggest number is " + d);
        }
        else//5th if statement.
        {
            Console.WriteLine("The biggest number is " + e);
        }

    }
}

