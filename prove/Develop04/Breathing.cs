
using System;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Threading;



class Breathing : Activities
{

    public override void RunActivity()
    {
        this.LoadAnimation();
        this.DisplayWelcome();
        int duration = this.GetDuration();

        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
        
        int countEnd = duration;
        int counter = 0;
        while(counter < countEnd)
        {
            int breatheCounter = 0;

            Console.WriteLine("Breathe In.....");

            while(breatheCounter < 5)
            {
                breatheCounter++;
                Console.WriteLine(breatheCounter);
                Thread.Sleep(1000);
                
            }
            
            Console.WriteLine("Breath Out....");
            
            while(breatheCounter > 0)
            {
                
                Console.WriteLine(breatheCounter);
                Thread.Sleep(1000);
                breatheCounter--;
                
            }
            counter++;
        }


        // duration not getting updated
        int secondsSpent = duration*10;
        Console.WriteLine(secondsSpent);
        this.DisplayEnd(secondsSpent);



    }

}