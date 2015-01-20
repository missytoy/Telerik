//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;
class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter an integer between 0 and 100: ");
        int number = int.Parse(Console.ReadLine());
        while (number < 0 || number > 1000)
        {
            Console.WriteLine("The number is less than 0 or bigger than 1000  ");
            Console.Write("Enter an integer between 0 and 100: ");
            number = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 1; i < 1000; i++)
        {
            if (number % i == 0)
                sum++;
        }
        bool result = !(sum > 2);
        Console.WriteLine("The number is prime: " + result);
        
    } 
}

