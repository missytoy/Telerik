//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;
class PointInCircleOutRectangle
{
    static void Main()
    {
        Console.Write("Enter x=");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y=");
        double y = double.Parse(Console.ReadLine());
        double r = 1.5;
        int centerX = 1;
        int centerY = 1;
        bool isInCircle = Math.Pow((x - centerX), 2) + Math.Pow((y - centerY), 2) <= Math.Pow(r, 2);
        //A(-1;1) , B(5;-1), C(5;1), D(-1;1) The coordinates of the rectangle 
        double left = -1, right = 5, top = 1, bottom = -1;
        bool isInRectangle = !(y <= top && y >= bottom && x >= left && x <= right);
        bool result = (isInRectangle && isInCircle);
        Console.WriteLine("The point is inside the circle and outside the rectangle: " + result);



    }

}
