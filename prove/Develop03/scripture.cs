using System;


class Scripture
{   
    private int wordsToHide;
    private string bookName;
    private int chapter;
    private int verseBegin;
    private int verseEnd;
    
    private Reference reference;
    

    public Scripture(string bookName, int chapter, int verseBegin, string reference)
    {
        this.bookName = bookName;
        this.chapter = chapter;
        this.verseBegin = verseBegin;
        this.verseEnd = verseBegin;
        this.reference = new Reference(reference);
    }
    public Scripture(string bookName, int chapter, int verseBegin, int verseEnd, string reference)
    {
        this.bookName = bookName;
        this.chapter = chapter;
        this.verseBegin = verseBegin;
        this.verseEnd = verseEnd;
        this.reference = new Reference(reference);
    }


    public void MemorizeScripture(int amountToHide = 1)
    {
        bool running = true;
        while (running) 
        {
        Console.Clear();
        
        if (this.reference.HideAll()) {

            running = false;
            Console.WriteLine("You have hidden all the words. Press enter to continue.");
        }
        else{
            Console.WriteLine($"{this}\n\nPress enter to continue or type 'quit' to finish.");
        }
        
        string input = Console.ReadLine();
        if (input == "quit") {
            break;
        }
        this.reference.HideWords(wordsToHide);
        }
    }
    public override string ToString() {
    string result = bookName + " " + chapter + ":" + verseBegin;
    if (verseBegin != verseEnd) {
        result += "-" + verseEnd;
    }
    result += " " + reference.ToString();
    return result;
}
}