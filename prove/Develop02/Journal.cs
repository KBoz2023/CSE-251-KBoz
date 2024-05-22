using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;





class Journal
{
    private string directoryPath;

    private string journalFilePath;

    private string journalFileName;
    private string response = "";
    private List<Entry> entryList = new List<Entry>();
 
    public void NewEntry()
    {
        string prompt = Entry.Prompt();
        // string prompt = prompter.ToString();

        Console.WriteLine(prompt);

        string journalEntry = Console.ReadLine();

        DateTime currentTime = DateTime.Now;
        string dateText = currentTime.ToShortDateString();

        Entry myEntry = new Entry(dateText, prompt, journalEntry);
        
        entryList.Add(myEntry);
    }

    public void MenuMethod()
    {

        Console.WriteLine("Hello Welcome to the Journal Program please select an option by typing the number");

  
        {
            string[] options = {"1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"};

            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
   
   
        }

    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entryList)
        {
            entry.Display();
        }
    }

    public void SaveJournal()
    {
        Console.Write("Enter the directory path where the CSV file should be created: ");
        string directoryPath = Console.ReadLine();
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        Console.WriteLine($"would you like to overwrite an existing file(1) or save to a new file(2) please type the number");
        string response = Console.ReadLine();

        if (response == "1")
        {
            // overwrite file in directory
            Console.WriteLine("what file would you like to save to");

            // Iterate through the directory
            string[] files = Directory.GetFiles(directoryPath);
            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }

            Console.WriteLine("________________________");
            Console.WriteLine("please type what file you would like to save to");
            string journalFileName = Console.ReadLine();
            string journalFilePath = Path.Combine(directoryPath, journalFileName);

            using (StreamWriter writer = new StreamWriter(journalFilePath, false)) // overwrite mode
            {
            foreach (Entry entry in entryList)
            {
                string line = $"{entry.date}<|>{entry.prompt}<|>{entry.content}";
                writer.WriteLine(line);
            }

            }

            
        }

        else if(response == "2")
        {
            // create new file in directory
            Console.WriteLine("please type what you want to name the file");
            string journalFileName = Console.ReadLine();
            string journalFilePath = Path.Combine(directoryPath, journalFileName);

            // writes new file
            using (StreamWriter writer = new StreamWriter(journalFilePath, true)) // Append mode
            {
                foreach (Entry entry in entryList)
                {
                    string line = $"{entry.date},{entry.prompt},{entry.content}";
                    writer.WriteLine(line);
                }

            }
            
        }


    }

    public string[] LoadJournal()
    {
        Console.WriteLine("What directory would you like to load journals from");
        string directoryPath = Console.ReadLine();

        if (!Directory.Exists(directoryPath))
        {
            Console.WriteLine($"the directory '{directoryPath}' does not exist");
        }

        else
        {
            string[] files = Directory.GetFiles(directoryPath);
            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }

            Console.WriteLine("What journal would you like to load to");
            string chosenJournal = Console.ReadLine();

            string path = Path.Combine(directoryPath, chosenJournal);

            if (File.Exists(path))
            {
                return File.ReadAllLines(path);
            }

            
        }
        return null;

    }


}