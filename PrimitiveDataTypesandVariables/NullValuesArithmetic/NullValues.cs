//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;
class NullValues
{
    static void Main()
    {
        int? nullableInt = null;
        double? nullableDouble = null;
        Console.WriteLine("Nullable int : " + nullableInt);
        Console.WriteLine("Nullable double : " + nullableDouble);
        nullableInt += 10;
        nullableDouble += 9.9;
        Console.WriteLine("Nullable int + 10 : " + nullableInt);
        Console.WriteLine("Nullable double + 9.9 : " + nullableDouble);
        nullableInt = 10;
        nullableDouble = 9.9;
        Console.WriteLine("Int number : " + nullableInt);
        Console.WriteLine("Double number : " + nullableDouble);
                
    }
}

