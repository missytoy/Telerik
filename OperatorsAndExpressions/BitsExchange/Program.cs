//Problem 15.* Bits Exchange

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;
class Program
{

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 3, j = 24; i < 6; i++, j++)
        {
            if (((number >> i) & 1) != ((number >> j) & 1))
            {
                number = ChangeBits(number, i, j);
            }
        }
        Console.WriteLine("Result: " + number);
    }

    private static int ChangeBits(int number, int firstposition, int secondPosition)
    {
        number ^= (1 << firstposition);
        return number ^ (1 << secondPosition);
    }

}

