//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation 
//ax2 + bx + c = 0 and solves it (prints its real roots).

using System;
using System.Threading;
using System.Globalization;
class FindRoots
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //To ensure the decimal separator is "." not ","
        string aString, bString, cString = null;
        double a, b, c, discriminant, x1, x2;

        Console.Write("Enter a=");
        aString = Console.ReadLine();
        aString = aString.Replace(",", ".");
        a = Double.Parse(aString);

        Console.Write("Enter b=");
        bString = Console.ReadLine();
        bString = bString.Replace(",", ".");
        b = Double.Parse(bString);

        Console.Write("Enter c=");
        cString = Console.ReadLine();
        cString = cString.Replace(",", ".");
        c = Double.Parse(cString);

        discriminant = Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c));

        if (discriminant > 0)
        {
            x1 = (-b - discriminant) / (2 * a);
            x2 = (-b + discriminant) / (2 * a);
            Console.WriteLine("The roots of the quadratic equation are: x1={0:f2} and x2={1:f2}.", x1, x2);
        }
        else if (discriminant == 0)
        {
            x1 = (-b / 2 * a);
            Console.WriteLine("The quadratic equation has only one root: {0:f2}}=", x1);
        }
        else
            Console.WriteLine("This quadratic equation don't have real roots!");


    }
}

