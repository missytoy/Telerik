//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter
//and area formatted with 2 digits after the decimal point.

using System;
using System.Threading;
using System.Globalization;

class Circle
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //To ensure the decimal separator is "." not ","
        Console.Write("Enter radius (r):");
        string r = Console.ReadLine();
        r = r.Replace(",", ".");
        double radius = Convert.ToDouble(r);
        double perimetur = Math.PI * 2 * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("The perimeter of circle with radius {0} is {1:F2}.", r, perimetur);
        Console.WriteLine("The area of circle with radius {0} is {1:F2}.", r, area);
    }
}
