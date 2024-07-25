

using System.Security.Cryptography;

class Menu
{
    private string[] menuList = ["Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"];
    private int count = 0;

    public void DisplayMenu()
    {
        foreach (string option in menuList)
        {
            count ++;
            Console.WriteLine($"{count}. {option}");
        }
        Console.WriteLine("Select a Choice from the menu");
    }
    public void MenuNav()
    {
        int userChoice = Convert.ToInt32(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                NewGoal();
                break;

            case 2:
                ListGoal();
                break;

            case 3:
                SaveGoal();
                break;
            
            case 4:
                Load Goal();
                break;
            
            case 5:
                return;
            



        }
    }


}