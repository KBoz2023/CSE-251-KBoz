using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guess = 0;
        do{
            // Console.WriteLine($"the magic number is: {magicNumber}");
            Console.Write("Guess a number: ");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess > magicNumber) {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber){
                Console.WriteLine("Higher");
            }


        } while(magicNumber != guess);


    }       
}
    