//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold 
//the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;
class ChangeBit
{
    static void Main()
    {
        Console.Write("Enter a positive integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Binay representation of the number {0}: {1}"
            , number, Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.Write("Enter a position (from right to left starting with 0) : ");
        int index = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit value (0 or 1) : ");
        int bit = int.Parse(Console.ReadLine());
        while (bit != 0 && bit != 1)
        {
            Console.Write("Enter a bit value (0 or 1) : ");
            bit = int.Parse(Console.ReadLine());

        }
        if (bit == 0)
        {
            int mask = ~(1 << index);
            int result = number & mask;
            Console.WriteLine("Before:" + Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("After:" + Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine("In decimal system :" + result);
        }
        else
        {
            int mask = (1 << index);
            int result = number | mask;
            Console.WriteLine("Before:" + Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("After :" + Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine("In decimal system :" + result);
        }
    }
}

