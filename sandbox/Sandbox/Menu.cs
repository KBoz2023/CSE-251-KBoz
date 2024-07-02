using System;
using System.Buffers;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;

class Menu
{
    public void menuMethod()
    {
        Console.WriteLine("Please pick an option");

        string[] optionMenu = new string[]
        {
            "1. add room",
            "2. add devices to room",
            "3. check device status",
            "4. check device on time",
            "5. Serialize house"
        };
        foreach(string option in optionMenu)
        {
            Console.WriteLine(option);
        }
        string userResponse = Console.ReadLine();

        if (userResponse == "1")
        {
            Home addRoom = new Home();
            addRoom.roomCreate();
        }
        else if(userResponse == "2")
        {

        }

        else if(userResponse == "3")

        {

        }

        else if(userResponse == "4")
        {

        }

        else if(userResponse == "5")
        {

        }
        else
        {
            Console.WriteLine("Invalid option");
        }

        
    }


}