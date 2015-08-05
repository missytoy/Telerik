//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
using System.Threading;
using System.Globalization; //To ensure the decimal separator is "." not ","

class Trapezoid
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; //To ensure the decimal separator is "." not ","

        Console.Write("Enter the first side of the trapezoid: ");
        string aString = Console.ReadLine();
        aString = aString.Replace(",", ".");//Replacing ","with"."
        double a = double.Parse(aString);
        while (a < 0)
        {
            Console.Write("Enter the first side of the trapezoid: ");
            aString = Console.ReadLine();
            aString = aString.Replace(",", ".");
            a = double.Parse(aString);
        }

        Console.Write("Enter the second side of the trapezoid: ");
        string bString = Console.ReadLine();
        bString = bString.Replace(",", ".");
        double b = double.Parse(bString);
        while (b < 0)
        {
            Console.Write("Enter the second side of the trapezoid: ");
            bString = Console.ReadLine();
            bString = bString.Replace(",", ".");
            b = double.Parse(bString);
        }

        Console.Write("Enter the height of the trapezoid: ");
        string hString = Console.ReadLine();
        hString = hString.Replace(",", ".");
        double h = double.Parse(hString);
        while (h < 0)
        {
            Console.Write("Enter the height of the trapezoid: ");
            hString = Console.ReadLine();
            hString = hString.Replace(",", ".");
            h = double.Parse(hString);
        }

        double area = ((a + b) * h) / 2;
        Console.WriteLine("The trapecoid's area is: " + area);
    }
}

