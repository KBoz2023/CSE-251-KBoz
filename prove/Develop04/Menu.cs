using System;




class Menu{


    public void PrintMenu()
    {
        List<string> menuList = new List<string>
        {
            "1. Breathing",
            "2. Listing",
            "3. Reflecting",
            "4. Quit"
        };
        foreach(string option in menuList)
        {
            Console.WriteLine(option);
        }
    }
}