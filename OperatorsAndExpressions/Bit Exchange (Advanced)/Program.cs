//Problem 16.** Bit Exchange (Advanced)

//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer number: ");
        uint number = Convert.ToUInt32(Console.ReadLine());
        uint numberSame = number;
        //We use the same number (int numberSame) in the second loop "for" 
        //because the value of "number" has change in the first loop "for" but we need the original.
        Console.WriteLine("The number " + number + " in binary is: " + Convert.ToString(number, 2).PadLeft(32, '0'));

        Console.Write("How much bits do you want to change (K): ");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bits from P to (P+K) has to change with bits from Q to (Q+K): ");
        Console.Write("Enter P: ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Q: ");
        int q = Convert.ToInt32(Console.ReadLine());
        uint mask = 0;
        int bit = 0;
        int index = 0;
        int numToIndex = 0;

        for (int i = 0; i < k; i++)
        {
            index = p + i;
            numToIndex = (int)(number >> index);
            bit = (int)(numToIndex & 1);
            if (bit == 1)
            {
                mask = (uint)(1 << q + i);
                number = (uint)(number | mask);
            }
            else
            {
                mask = (uint)~(1 << q + i);
                number = (uint)(number & mask);
            }
        }


        for (int i = 0; i < k; i++)
        {
            index = q + i;
            numToIndex = (int)(numberSame >> index);
            bit = numToIndex & 1;
            if (bit == 1)
            {
                mask = (uint)(1 << p + i);
                number = (uint)(number | mask);
            }
            else
            {
                mask = (uint)~(1 << p + i);
                number = (uint)(number & mask);
            }
        }

        Console.WriteLine("After exchanging bits :" + Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("In decimal system :" + number);
    }
}
