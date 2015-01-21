//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;
using System.Threading;
using System.Globalization;

class Compare
{
    static void Main()
    {
        {
            //To ensure the decimal separator is "." and not ",". 
            //Addin and "using System.Threading;" and " using System.Globalization; "
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double firstNumber, secondNumber;
            string firstString = null, secondString = null;

            Console.Write("Enter first real number :");
            firstString = Console.ReadLine();
            firstString = firstString.Replace(",", ".");
            firstNumber = Double.Parse(firstString);

            Console.Write("Enter second real number :");
            secondString = Console.ReadLine();
            secondString = secondString.Replace(",", ".");
            secondNumber = Double.Parse(secondString);

            double menos = firstNumber - secondNumber;
            //To ensure that the number is positive we use Math.abs()
            bool isEqual = Math.Abs(menos) < 0.000001;
            Console.WriteLine("Are these numbers equal? {0}", isEqual);
        }
    }
}

