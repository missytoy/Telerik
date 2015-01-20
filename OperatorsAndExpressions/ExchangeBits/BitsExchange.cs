//Problem 15.* Bits Exchange

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;
class BitsExchange
{

    static void Main()
    {
        Console.Write("Enter a positive integer number: ");
        uint number = Convert.ToUInt32(Console.ReadLine());
        uint numberSame = number;
        //We use the same number (int numberSame) in the second loop "for" 
        //because the value of "number" has change in the first loop "for" but we need the original.
        Console.WriteLine("The number " + number + " in binary is: " + Convert.ToString(number, 2).PadLeft(32, '0'));
        uint mask = 0; 
        int bit = 0;
        int index = 0;
        int numToIndex = 0;
        // 3,4,5 to 24,25,26
        for (int i = 0; i <3; i++)
        {
            index = 3 + i;
            numToIndex = (int)(number >> index);
            bit = (int)(numToIndex & 1);
            if (bit == 1)
            {
                mask = (uint) (1 << 24 + i);
                number = (uint)(number | mask);
            }
            else
            {
                mask = (uint)~(1 << 24 + i);
                number = (uint)(number & mask);
            }
        }

        // 24,25,26 to 3,4,5
        for (int i = 0; i < 3; i++)
        {
            index = 24 + i;
            numToIndex = (int)(numberSame >> index);
            bit = numToIndex & 1;
            if (bit == 1)
            {
                mask = (uint) (1 << 3 + i);
                number = (uint)(number | mask);
            }
            else
            {
                mask = (uint)~(1 << 3 + i);
                number = (uint)(number & mask);
            }
        }     
        
        Console.WriteLine("After exchanging bits 3,4,5 to 24,25,26 :" + Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("In decimal system :" + number);
    }

}
