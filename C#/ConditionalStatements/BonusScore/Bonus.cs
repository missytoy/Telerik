//Problem 2. Bonus Score

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.

using System;
class Bonus
{
    static void Main()
    {
        Console.Write("Enter a number in the range [1…9]:");
        int number = int.Parse(Console.ReadLine());
        if (number >= 1 && number <= 3)
        {
            number *= 10;
            Console.WriteLine(number);
        }
        else if (number >= 4 && number <= 6)
        {
            number *= 100;
            Console.WriteLine(number);
        }
        else if (number >= 7 && number <= 9)
        {
            number *= 1000;
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}
