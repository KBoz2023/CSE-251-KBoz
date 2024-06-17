using System;


class Reflecting : Activities
{
    public override void RunActivity()
    {
        this.LoadAnimation();
        this.DisplayWelcome();
        int time = this.GetDuration();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Random promptSelector = new Random(0-3);
        int selectedPrompt = Convert.ToInt32(promptSelector);

        string[] prompts = new string[]
        {
            "Think of a Time where you did something you didn't think that you could",
            "Think of a Time when you learned from a mistake",
            "Whats a tradition from your childhood that you still cherish",
            "Think of a place you loved visiting when you were younger"
        };

        Console.WriteLine(prompts[selectedPrompt]);


        string[] questions = new string[]
        {
            "Why is this important to you",
            "what impact does it have in your life",
            "How did it start",
            "",
            ""

        };

        int rate = time / 5;
        foreach(string question in questions)
        {
            Console.WriteLine(question);
            this.LoadAnimation(rate, 200);
        }
        this.DisplayEnd(time);
    }





}