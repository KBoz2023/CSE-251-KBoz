using System;

class Bank 
{
    public float balance = 12;

    public float Withdraw()
    {
        Console.WriteLine("How much would you like to withdraw: ");
        float amount = float.Parse(Console.ReadLine());

        if (amount > this.balance)
        {
            Console.WriteLine("insufficient funds");
            return 0;
        }
        this.balance -= amount;
        Console.WriteLine($"your balance is {this.balance}");
        return amount;
    }    
    public float GetAccountBalance()
    {
        return this.balance;
    }
}