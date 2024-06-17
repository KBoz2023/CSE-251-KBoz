using System;
using System.Diagnostics;
using System.Net;


class Listing: Activities
{
    public override void RunActivity()
    {
        this.DisplayWelcome();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");
        int time =  this.GetDuration();


        Random promptSelector = new Random(0-3);
        int selectedPrompt = Convert.ToInt32(promptSelector);

        string[] prompts = new string[]
        {
            "Who are some people that you appreciate in your life",
            "When have you felt the Holy Ghost this month",
            "Who are your Role Models in Life",
            "Who have you helped this week"
        };
        List<string>responses = new List<string>();

        Console.WriteLine("Ponder this prompt");
        Console.WriteLine(prompts[selectedPrompt]);


        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();


        while(stopWatch.Elapsed.TotalSeconds < time)
        {
            responses.Add(Console.ReadLine());
            
        }
        stopWatch.Stop();


        foreach(string response in responses)
        {
            Console.WriteLine(response);
        }




        int timeSpent = time+5;
        this.DisplayEnd(timeSpent);

    }
    

}