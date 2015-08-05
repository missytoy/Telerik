//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;
class FourDigit
{
    static void Main()
    {
        Console.Write("Enter a four-digit number: ");
        int number = int.Parse(Console.ReadLine());
        while (number < 1000 || number > 9999)
        {
            Console.Write("Enter a fout-digit number: ");
            number = int.Parse(Console.ReadLine());
        }

        int fourth = number % 10;
        int third = (number / 10) % 10;
        int second = (number / 100) % 10;
        int first = (number / 1000) % 10;
        int sum = first + second + third + fourth;
        Console.WriteLine("Sum of digits :" + sum);
        Console.WriteLine("Reversed : {3}{2}{1}{0}", first,second,third,fourth);
        Console.WriteLine("Last digit in front : {3}{0}{1}{2}", first, second, third, fourth);
        Console.WriteLine("Second and third digits exchanged : {0}{2}{1}{3}", first, second, third, fourth);
    }
}

