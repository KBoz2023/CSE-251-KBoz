using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
    
    Fractions fraction1 = new Fractions();
        fraction1.Display(); 

        
    Fractions fraction2 = new Fractions(5);
    fraction2.Display(); 

        
    Fractions fraction3 = new Fractions(3, 4);
    fraction3.Display(); 

       
    fraction3.Numerator = 7;
    fraction3.Denominator = 8;
    Console.WriteLine($"Numerator: {fraction3.Numerator}");
    Console.WriteLine($"Denominator: {fraction3.Denominator}");
      
    fraction3.Display();
    } 

   
}