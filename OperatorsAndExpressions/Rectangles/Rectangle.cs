//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;
class Rectangle
{
    static void Main()
    {
        Console.Write("Enter a width: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter a height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        double perimeter = (2 * width) + (2 * height);
        double area = width * height;
        Console.WriteLine("The perimeter is:" + perimeter);
        Console.WriteLine("The area is: " + area);
    }
}
