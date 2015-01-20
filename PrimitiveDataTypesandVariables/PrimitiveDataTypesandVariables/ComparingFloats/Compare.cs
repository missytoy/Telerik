//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

using System;
class Compare
{
    static void Main()
    {
        {
            double firstNumber, secondNumber;
            Console.Write("Enter first real number  (with \",\" not \".\") :");
            firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second real number  (with \",\" not \".\") :");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            bool isEqual = (firstNumber - secondNumber) < 1e-6;
            Console.WriteLine("Are these numbers equal? {0}", isEqual);
        }
    }
}

