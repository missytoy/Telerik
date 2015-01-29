//Problem 8. Numbers from 1 to n

//Write a program that reads an integer number n from the console 
//and prints all the numbers in the interval [1..n], each on a single line.

using System;
class From1ToN
{
    static void Main()
    {
        Console.Write("Enter end of interval (integer) n= ");
        int n = int.Parse(Console.ReadLine());
        while (n < 0 || n > 2147483647)
        {
            Console.Write("Enter end of interval (integer) n= ");
            n = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
