using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your current grade percentage in this course?(do not put in a percentage sign)");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);
        string sign = null;
        string letter = null;
        if (grade <= 93 && grade > 60)
        {
            int first = grade % 10;
            if (first >= 7)
            {
                sign = "+";
            }
            else if (first <= 3)
            {
                sign = "-";
            }
        }

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        
        Console.WriteLine($"Your grade is a {letter}{sign}");
        
        if (letter == "F" || letter == "D")
        {
            Console.WriteLine("I'm sorry but you did not pass this course. Better luck next time!");
            
        }
        else
        {
            Console.WriteLine("Congratulations! You passed this course good job!");
        }
    }
}