//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

using System;
class Fibonacci
{
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        while (n < 0 || n > 2147483647)
        {
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
        }

        int a = 0, b = 1, c = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}, ", a);
            c = a + b;
            a = b;
            b = c;
        }
    }
}


