//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.

using System;
class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter a number (int) : ");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Number is even");
        }
        else
            Console.WriteLine("Number is odd");
    }
}
