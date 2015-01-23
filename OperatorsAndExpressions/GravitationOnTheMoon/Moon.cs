//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;
using System.Threading;
using System.Globalization; //To ensure the decimal separator is "." not ","

class Moon
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter a weight: ");
        string weightString = Console.ReadLine();
        weightString = weightString.Replace(",", ".");
        double weight = double.Parse(weightString);
        double weightOnTheMon = weight * (17.0 / 100);
        Console.WriteLine("Weight on the Moon is :" + weightOnTheMon);
    }
}

