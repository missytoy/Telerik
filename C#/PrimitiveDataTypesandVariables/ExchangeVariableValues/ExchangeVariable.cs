//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

using System;
class ExchangeVariable
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int helper;
        Console.WriteLine("Before : a is {0} and b is {1}.", a, b);
        helper = a;
        a = b;
        b = helper;
        Console.WriteLine("After : a is {0} and b is {1}.", a, b);
    }
}

