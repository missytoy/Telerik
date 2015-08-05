//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers 
//and calculates and prints their sum. Note: You may need to use a for-loop.

using System;
using System.Threading;
using System.Globalization;
class SumNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //To ensure the decimal separator is "." not ","

        Console.Write("How much numbers do you want to sum up? n=");
        int n = int.Parse(Console.ReadLine());
        while (n < 0 || n > 2147483647)
        {
            Console.Write("How much numbers do you want to sum up? n=");
            n = int.Parse(Console.ReadLine());
        }
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} number is: ",i+1);
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum is: "+sum);
    }
}

