//Problem 5. Formatting Numbers

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

using System;
using System.Threading;
using System.Globalization;
class FormattingNum
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //To ensure the decimal separator is "." not ","

        Console.Write("Enter a (0 <= a <= 500) =");
        int a = int.Parse(Console.ReadLine());
        while (a < 0 || a > 500)
        {
            Console.Write("Enter a (0 <= a <= 500) =");
            a = int.Parse(Console.ReadLine());
        }

        string bString, cString = null;
        double b, c;

        Console.Write("Enter b=");
        bString = Console.ReadLine();
        bString = bString.Replace(",", ".");
        b = Double.Parse(bString);

        Console.Write("Enter c=");
        cString = Console.ReadLine();
        cString = cString.Replace(",", ".");
        c = Double.Parse(cString);

        Console.WriteLine("|{0,-10}|{1}|{2,10:F2}|{3,-10:F3}|",
            Convert.ToString(a, 16).ToUpper(), Convert.ToString(a, 2).PadLeft(10, '0'), b, c);

    }
}

