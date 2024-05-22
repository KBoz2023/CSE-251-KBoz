using System;



class Entry
{
    public string date = "";

    public string prompt = "";

    public string content = "";

    public Entry(string date, string prompt, string content)
    {
        this.date = date;
        this.prompt = prompt;
        this.content = content;
        
    }


    public static string Prompt()
    {
        List<string> prompts =  ["What am I grateful for today", "What was the highlight of my day", "What is one thing I could have done better today", "What was the most challenging part of my day", "What did I learn today"];
        Random random = new Random();
        int randomPrompt = random.Next(prompts.Count);

        if (prompts[randomPrompt].Length > 0){
            return prompts[randomPrompt];
        }

        return "";
    }

    



    public void Display(){
        Console.WriteLine($"{this.prompt}, [{this.date}]\n{this.content}");
    }
    // private List<Entry> entries = new List<Entry>;

    // test code for writing an entry with date prompt and text into a list as a list letting you iterate throught the entry by those three items
//     List<List<Entry>> journals= new List<List<Entry>>();
//         journals.Add(New journalEntries);


//         // to iterate through the listed list
//         foreach (journal in journals)
//         {
//             foreach (entry in journalEntries)
//                 {
//                     Console.WriteLine(entry)
//                 }
//         }
}