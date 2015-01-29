//Problem 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
//Submit the source code of your Visual Studio project as part of your homework submission

using System;


class Variables
{
    static void Main()
    {

        ushort firstNumber = 52130;
        sbyte secondNumber = -115;
        int thirdNumber = 4825932;
        byte fourthNumber = 97;
        short fifthNumber = -10000;
        Console.WriteLine(@"Ushort variable is  {0}, sbyte variable is {1}, int variable is {2},
byte variable is {3}, short variable is {4}.",
            firstNumber,secondNumber,thirdNumber,fourthNumber,fifthNumber);
    }
}

