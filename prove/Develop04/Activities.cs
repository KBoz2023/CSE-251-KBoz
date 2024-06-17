using System;


abstract class Activities
{
    int duration = 0;
    public virtual void LoadAnimation(int seconds = 3, int speed = 200)
    {
        string[] spinner = {"W", "E", "M", "3"};
        int runTime = seconds * 1000; // Convert seconds to milliseconds
        while (runTime > 0) {
           for (int i = 0; i < 4; i++) {
               Console.Write(spinner[i]); // Display the current spinner character
               Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // Move the cursor back one position
               System.Threading.Thread.Sleep(speed); // Pause for the specified speed
               runTime -= speed; // Decrease the remaining runtime by the speed
               Console.Write(" "); // Clear the spinner character
               Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
               }
        }
    }



    public virtual int GetDuration()
    {
        duration = Convert.ToInt32(Console.ReadLine());
        return duration;
    }

    public virtual void RunActivity()
    {
        Console.WriteLine("No overwrite detected");
    }
    public virtual void DisplayWelcome()
    {
        Console.WriteLine("Thank you for choosing this activity please type in the duration you would like to use:");
    }
    public virtual void DisplayEnd(int duration)
    {
        Console.WriteLine($"You spent {this.duration} seconds on this activity");
    }

}