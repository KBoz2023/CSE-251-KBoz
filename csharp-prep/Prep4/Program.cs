using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");


        Console.WriteLine("Enter a list of numbers type 0 when done");
        List<int> numbers = new List<int>();
        int newNumber = 0;
        int maxNum = 0;
        do {
            Console.Write("Enter number: ");
            newNumber = Convert.ToInt32(Console.ReadLine());
            numbers.Add(newNumber);
            if (newNumber > maxNum)
            {
                maxNum = newNumber;
            }

        } while (newNumber !=0);

        int sum = 0;
        int numCount = 0;

        foreach(int number in numbers)
        {
            sum += number;
            numCount ++;
            
        }
        Console.WriteLine($"The total of the list is: {sum}");
        int avgNum = sum / numCount; 
        Console.WriteLine($"The average number is: {avgNum}");
        Console.WriteLine($"The largest number is: {maxNum}");

    }
}