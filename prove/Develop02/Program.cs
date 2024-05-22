using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        

        while(true)
        {
            myJournal.MenuMethod();
            string userInput = Console.ReadLine();

                    // write
                    if (userInput == "1")
                        {
                            myJournal.NewEntry();
                            
                        }

                    // Display
                    else if (userInput == "2")
                    {
                        myJournal.DisplayEntries();
                    }

                    // Load
                    // else if (userInput == "3")
                    // {
                    //     myJournal.LoadJournal();
                    // }

                    // // Save method
                    // else if (userInput == "4")
                    // {
                    //     myJournal.SaveJournal();
                    // }

                    // break menu loop
                    else if (userInput == "5")
                    {

                        Console.Write("Thank you for using the Journal Program. Have a good Day");
                        break;
                    }

                    // error handling
                    else
                    {
                        Console.WriteLine("Invalid option detected please select a valid option");
                    }
        }
    }
}