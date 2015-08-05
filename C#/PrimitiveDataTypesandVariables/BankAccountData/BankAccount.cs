//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;
class BankAccount
{
    static void Main()
    {
        string firstName = "Hrisina";
        string middleName = "Hristova";
        string lastName = "Hristova";
        decimal money = 999.99m;
        string bankName = "Unicredit Bulbank";
        string iBAN = "BG00UNCR12311012345678";
        long firstCard = 934556743212345;
        long secondCard = 891235092123456;
        long thirdCard = 584836167891234;

        Console.WriteLine("Name: " + firstName + " " + middleName + " " + lastName
           + "\nBalance: " + money + " lv."
           + "\nBank: " + bankName
           + "\nIBAN: " + iBAN
           + "\nCredit Card 1: " + firstCard
           + "\nCredit Card 2: " + secondCard
           + "\nCredit Card 3: " + thirdCard);


    }
}
