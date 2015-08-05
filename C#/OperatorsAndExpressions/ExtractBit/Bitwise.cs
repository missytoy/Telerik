//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;
class Bitwise
{
    static void Main()
    {
        Console.Write("Enter a positive integer number: ");
        int number = int.Parse(Console.ReadLine());
        int position = 3;
        int mask = 1 << position;
        int nAndMask = number & mask;
        int bit = nAndMask >> position;
        Console.WriteLine("Binay representation: {0}", Convert.ToString(number, 2).PadLeft(16,'0'));
        Console.WriteLine("The 3th bit (4th number from right to left) is: " + bit);
    }
}


