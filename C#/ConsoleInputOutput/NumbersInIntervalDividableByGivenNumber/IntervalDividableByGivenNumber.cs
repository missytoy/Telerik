//Problem 11.* Numbers in Interval Dividable by Given Number

//Write a program that reads two positive integer numbers and prints how many numbers p exist 
//between them such that the reminder of the division by 5 is 0.

using System;
class IntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter start (integer)=");
        int start = int.Parse(Console.ReadLine());
        while (start < 0 || start > 2147483647)
        {
            Console.Write("Enter start(integer)=");
            start = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter end (integer) =");
        int end = int.Parse(Console.ReadLine());
        while (end < 0 || end > 2147483647)
        {
            Console.Write("Enter end (integer)=");
            end = int.Parse(Console.ReadLine());
        }

        int p = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
                p++;
            }


        }
        if (p == 1)
        {
            Console.WriteLine("Between {0} and {1} there is only {2} number which reminder of the division by 5 is 0 ",
                start, end, p);
        }
        else if (p>1 && p<2147483647)
        Console.WriteLine("Between {0} and {1} there are {2} numbers which reminder of the division by 5 is 0 ",
            start, end, p);
        else
        {
            Console.WriteLine("There aren't any number between {0} and {1}  which reminder of the division by 5 is 0 ",start,end);
        }
    }
}
