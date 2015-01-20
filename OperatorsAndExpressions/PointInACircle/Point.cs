//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
class Point
{
    static void Main()
    {
        Console.Write("Enter x=");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y=");
        double y = double.Parse(Console.ReadLine());
        int r = 2;
        int centerX = 0;
        int centerY = 0;
        bool result = Math.Pow((x - centerX), 2) + Math.Pow((y - centerY), 2) <= Math.Pow(r, 2);
        Console.WriteLine("The point with coordinates ({0};{1}) is inside the circle: {2} ",
            x,y,result);


    }
}

