//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;
using System.Threading;
using System.Globalization; //To ensure the decimal separator is "." not ","
class IntDoubleOrString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Please choose a type (1 for int, 2 for double and 3 for string):");
        int number = int.Parse(Console.ReadLine());
        while (number < 1 || number > 3)
        {
            Console.Write("Please choose a type (1 for int, 2 for double and 3 for string):");
            number = int.Parse(Console.ReadLine());
        }

        switch (number)
        {
            case 1:
                {
                    Console.Write("Please enter an integer number:");
                    int numberInt = int.Parse(Console.ReadLine());
                    numberInt++;
                    Console.WriteLine("After increasing it by one: " + numberInt);
                } break;

            case 2:
                {
                    Console.Write("Please enter a real number(double): ");
                    string stringDouble = Console.ReadLine();
                    stringDouble = stringDouble.Replace(",", ".");
                    double numberDouble = double.Parse(stringDouble);
                    numberDouble++;
                    Console.WriteLine("After increasing it by one: " + numberDouble);
                } break;
            case 3:
                {
                    Console.Write("Please enter a string:");
                    string someString = Console.ReadLine();
                    Console.WriteLine("{0}*", someString);
                } break;
            default: Console.WriteLine("Wrong input");
                break;
        }
    }
}