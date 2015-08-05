//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;
using System.Threading;  
using System.Globalization; 

class Rectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
       
        Console.Write("Enter a width: ");
        string widthString = Console.ReadLine();
        widthString = widthString.Replace(",", ".");
        double width = double.Parse(widthString);
        
        Console.Write("Enter a height: ");
        string heightString = Console.ReadLine();
        heightString = heightString.Replace(",", ".");
        double height = double.Parse(heightString);

        double perimeter = (2 * width) + (2 * height);
        double area = width * height;
        Console.WriteLine("The perimeter is:" + perimeter);
        Console.WriteLine("The area is: " + area);
    }
}
