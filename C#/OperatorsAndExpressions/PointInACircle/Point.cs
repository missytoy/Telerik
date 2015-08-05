//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
using System.Threading;
using System.Globalization; //To ensure the decimal separator is "." not ","

class Point
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter x=");
        string xString = Console.ReadLine();
        xString = xString.Replace(",", ".");
        double x = double.Parse(xString);

        Console.Write("Enter y=");
        string yString = Console.ReadLine();
        yString = yString.Replace(",", ".");
        double y = double.Parse(xString);

        int r = 2;
        int centerX = 0;
        int centerY = 0;
        bool result = Math.Pow((x - centerX), 2) + Math.Pow((y - centerY), 2) <= Math.Pow(r, 2);
        Console.WriteLine("The point with coordinates ({0};{1}) is inside the circle: {2} ",
            x, y, result);


    }
}

