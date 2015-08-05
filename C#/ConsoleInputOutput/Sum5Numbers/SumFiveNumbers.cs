//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space),
//calculates and prints their sum.

using System;
using System.Threading;
using System.Globalization;

class SumFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //To ensure the decimal separator is "." not ","

        Console.WriteLine("Enter five numbers(separated by spaces):");
        //Read line, and split it by whitespace into an array of strings.
        string[] numbers = Console.ReadLine().Split(); 
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = numbers[i].Replace(",", ".");
            sum += double.Parse(numbers[i]);
        }

        Console.WriteLine("The sum of the numbers is {0}", sum);
    }
}