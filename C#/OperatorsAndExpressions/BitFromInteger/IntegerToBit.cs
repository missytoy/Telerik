//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.

using System;
class IntegerToBit
{
    static void Main()
    {

        Console.Write("Enter a positive integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Binay representation: {0}", Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.Write("Enter a position (from right to left starting with 0) : ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("The {0}th bit ({1}th number from right to left) is: {2}",
            index, index + 1, ((number >> index) & 1));

    }
}

