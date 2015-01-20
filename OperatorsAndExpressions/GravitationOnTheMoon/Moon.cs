//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;
class Moon
{
    static void Main()
    {
        Console.Write("Enter a weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        double weightOnTheMon = weight * (17.0 / 100);
        Console.WriteLine("Weight on the Moon is :" + weightOnTheMon);
    }
}

