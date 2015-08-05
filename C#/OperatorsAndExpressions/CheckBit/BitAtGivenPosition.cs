//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p 
//(counting from 0, starting from the right) in given integer number n, has value of 1.

using System;
class BitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter a positive integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Binay representation: {0}", Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.Write("Enter a position (from right to left starting with 0) : ");
        int index = int.Parse(Console.ReadLine());
        int result1 = ((number >> index) & 1);
        bool result2 = result1 == 1;
        Console.WriteLine("The bit in this position is 1:" + result2);


    }
}

