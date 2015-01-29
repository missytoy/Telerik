//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;
using System.Threading;
using System.Globalization; //To ensure the decimal separator is "." not ","
class PositiveOrNegative
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
        if (a == 0 || b == 0 || c == 0)//if one of the numbers is 0 then the answer is 0
        {
            Console.WriteLine("0");
        }
        else
        {
            if (a > 0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        Console.WriteLine("+");
                    }
                    else
                    {
                        Console.WriteLine("-");
                    }
                }
                else
                {
                    if (c > 0)
                    {
                        Console.WriteLine("-");
                    }
                    else
                    {
                        Console.WriteLine("+");
                    }
                }
            }
            else
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        Console.WriteLine("-");
                    }
                    else
                    {
                        Console.WriteLine("+");
                    }
                }
                else
                {
                    if (c > 0)
                    {
                        Console.WriteLine("+");
                    }
                    else
                    {
                        Console.WriteLine("-");
                    }
                }
            }
        }
    }
}
