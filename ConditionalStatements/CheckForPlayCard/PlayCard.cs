//Problem 3. Check for a Play Card

//Classical play cards use the following signs to designate the card face:
//`2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a 
//string and prints “yes” if it is a valid card sign or “no” otherwise. 

using System;
class PlayCard
{
    static void Main()
    {

        Console.Write("Enter card: ");
        string symbol = Console.ReadLine();
        Console.Write("Valid card sign? ");
        int s = 0;
        bool successfullyParsed = int.TryParse(symbol, out s);
        if (successfullyParsed)
        {
            s = int.Parse(symbol);
            if (s >= 2 && s <= 10)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        else
            if (symbol == "J" || symbol == "K" || symbol == "Q" || symbol == "A")
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
    }
}

