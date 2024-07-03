using System;
using System.Net;
using System.Runtime;
using System.Text.Json.Serialization;

class Reference
{   
    
    private List<Word> words = new List<Word>();
    private List<int> visibleIndices = new List<int>();

    private int wordsVisible;
    private Random randomWord = new Random();



    public void returnVerse(int verses)
    {
       
    }

    public Reference(string reference)
    {
        string[] words = reference.Split(' ');
        for(int i = 0; i < words.Length; i++)
        {
            this.words.Add(new Word(words[i]));
            this.visibleIndices.Add(i);
        }
        this.wordsVisible = words.Length;
        
    }
    public void HideWords(int wordsToHide)
    {
        for (int i = 0; i < wordsToHide; i++)
        {
        if (this.wordsVisible == 0)
        {
            break;
        }
        int index = randomWord.Next(0, this.wordsVisible);
        this.words[this.visibleIndices[index]].Hide();
        this.visibleIndices.RemoveAt(index);
        this.wordsVisible--;
        }
    }

    
    public bool HideAll()
    {
        return this.wordsVisible == 0;
    }



}