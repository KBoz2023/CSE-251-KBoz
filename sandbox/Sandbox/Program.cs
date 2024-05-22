using System;
using System.ComponentModel;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.Write("Do you want to play a game: ");

        Bank bank = new Bank();

        Console.WriteLine($"you have {bank.GetAccountBalance()}");
        bank.Withdraw();
    }
}