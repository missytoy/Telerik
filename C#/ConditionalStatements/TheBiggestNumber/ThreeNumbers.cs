//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

using System;
using System.Threading;
using System.Globalization; //To ensure the decimal separator is "." not ","

class ThreeNumbers
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
                Console.WriteLine("The biggest number from {0},{1} and {2} is {3}", a, b, c, a);
            }
            else
            {
                Console.WriteLine("The biggest number from {0},{1} and {2} is {3}", a, b, c, c);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("The biggest number from {0},{1} and {2} is {3}", a, b, c, b);
            }
            else
            {
                Console.WriteLine("The biggest number from {0},{1} and {2} is {3}", a, b, c, c);
            }
        }
    }
}