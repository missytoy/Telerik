//Problem 11.* Number as Words

//Write a program that converts a number in the range [0…999] to words,
//corresponding to the English pronunciation.

using System;
class NumberWord
{
    static void Main()
    {

        string firstNumber = null;
        string secondNumber = null;
        string thirdNumber = null;
        Console.Write("Write number between 0 and 999(including):");
        int number = int.Parse(Console.ReadLine());
        while (number <= 0 || number >= 999)
        {
            Console.Write("Write number between 0 and 999(including):");
            number = int.Parse(Console.ReadLine());

        }


        //hundred
        int hundred = (number / 100) % 10;

        switch (hundred)
        {

            case 1: firstNumber = "one"; break;
            case 2: firstNumber = "two"; break;
            case 3: firstNumber = "three"; break;
            case 4: firstNumber = "four"; break;
            case 5: firstNumber = "five"; break;
            case 6: firstNumber = "six"; break;
            case 7: firstNumber = "seven"; break;
            case 8: firstNumber = "eight"; break;
            case 9: firstNumber = "nine"; break;
            default: break;

        }
        //second number without 11,12,13..19
        int number2 = (number / 10) % 10;

        switch (number2)
        {
            case 2: secondNumber = "twenty"; break;
            case 3: secondNumber = "thirty"; break;
            case 4: secondNumber = "forty"; break;
            case 5: secondNumber = "fifty"; break;
            case 6: secondNumber = "sixty"; break;
            case 7: secondNumber = "seventy"; break;
            case 8: secondNumber = "eighty"; break;
            case 9: secondNumber = "ninety"; break;
            default: break;
        }

        int number3 = number % 10;
        switch (number3)
        {

            case 1: thirdNumber = "one"; break;
            case 2: thirdNumber = "two"; break;
            case 3: thirdNumber = "three"; break;
            case 4: thirdNumber = "four"; break;
            case 5: thirdNumber = "five"; break;
            case 6: thirdNumber = "six"; break;
            case 7: thirdNumber = "seven"; break;
            case 8: thirdNumber = "eight"; break;
            case 9: thirdNumber = "nine"; break;

        }
        if (number == 0)
        {
            Console.WriteLine(0);
        }
        else if (number >= 0 && number < 10)
        {
            Console.WriteLine("{0} ", thirdNumber);

        }
        else if (number >= 10 && number < 20)//second number (11,12,13..19)
        {

            switch (number)
            {
                case 10: Console.WriteLine("ten"); break;
                case 11: Console.WriteLine("elevan"); break;
                case 12: Console.WriteLine("twelve"); break;
                case 13: Console.WriteLine("thirteen"); break;
                case 14: Console.WriteLine("fourteen"); break;
                case 15: Console.WriteLine("fifteen"); break;
                case 16: Console.WriteLine("sixteen"); break;
                case 17: Console.WriteLine("seventeen"); break;
                case 18: Console.WriteLine("eighteen"); break;
                case 19: Console.WriteLine("nineteen"); break;
            }

        }
        else if (number >= 20 && number < 100)
        {
            Console.WriteLine("{0}-{1}", secondNumber, thirdNumber);
        }
        else if (hundred >= 1 && hundred < 10)
        {
            if (number2 == 0)
            {
                Console.WriteLine("{0} hundred and {1}", firstNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("{0} hundred {1}-{2}", firstNumber, secondNumber, thirdNumber);
            }
        }
        else
        {
            Console.WriteLine("Wrong number");
        }
    }
}