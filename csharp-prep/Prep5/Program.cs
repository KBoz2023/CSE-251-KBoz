using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        return userNumber;
    }

    static int SquareNumber(int number)
    {
            int numberSquared = (int)Math.Pow(number, 2);
            return numberSquared;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name} the square of your number is {number}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);


    }


}