using System;
using System.Linq.Expressions;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        while(true){
        Console.WriteLine("Please select an option by typing the number before the name: ");
        Menu menu = new Menu();

        menu.PrintMenu();

        String userInput = Console.ReadLine();

        
        if (userInput == "1")
        {
            Console.WriteLine("Breathing activity selected");
            Breathing breathing = new Breathing();
            breathing.RunActivity();

        }

        else if (userInput == "2")
        {
            // Listing
            Listing listing = new Listing();
            listing.RunActivity();

        }
        
        else if (userInput == "3")
        {
            // reflect
            Reflecting reflecting = new Reflecting();
            reflecting.RunActivity();
        }
        else if (userInput == "4")
        {
            // Quit
            Console.WriteLine("Thank you for using the Mindfulness Program. Have a nice day");
            break;
        }
        else
        {
            Console.WriteLine("Invalid option please try again");
        }


        }
    }
}