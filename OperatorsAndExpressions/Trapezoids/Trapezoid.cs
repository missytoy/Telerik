//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
class Trapezoid
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first side of the trapezoid: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second side of the trapezoid: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the height of the trapezoid: ");
        double h = double.Parse(Console.ReadLine());
        double area = ((a + b) * h) / 2;
        Console.WriteLine("The trapecoid's area is: " + area );
    }
}

