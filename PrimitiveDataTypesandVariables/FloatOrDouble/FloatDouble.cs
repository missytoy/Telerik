﻿//Problem 2. Float or Double?

//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatDouble
{
    static void Main()
    {
        double fistNumber = 34.567839023;
        float secondNumber = 12.345f;
        double thirdNumber = 8923.1234857;
        float fourtNumber = 3456.091f;

        Console.WriteLine("The double types are: {0} and {1} \nThe float types are: {2} and {3}.",
            fistNumber,thirdNumber,secondNumber,fourtNumber );
    }
}
