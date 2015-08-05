//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;
class ThirdDigit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        while (number < 100)
        {
            Console.WriteLine("The number must have at least 3 digits.");
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
        }
        bool result = (number / 100) % 10 == 7;
        Console.WriteLine("Third digit of the number is 7: " + result);
    }
}