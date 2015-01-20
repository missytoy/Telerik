//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;
class Dividing
{
    static void Main()
    {
        Console.Write("Enter a number (int): ");
        int number = int.Parse(Console.ReadLine());
        bool result = (number % 5 == 0) && (number % 7 == 0);
        Console.WriteLine("The number can be divided (without remainder) by 7 and 5 at the same time. "
            + result +"\n");
    }
}

