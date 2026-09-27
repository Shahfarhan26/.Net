
using System;

class Program
{
    static void Main(string[] args)
    {
        BankAccount b1 = new BankAccount("trex",10000);
        bool exit = false;
        Console.WriteLine("welcome to your Bank Account.");
        bool depositPossible;
        bool withdrawPossible;
        while (!exit)
        {
            Console.WriteLine("press 1 to display balance.\npress 2 to withdraw\npress 3 to deposit\npress 4 to exit.");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    b1.DisplayBalance();
                    break;
                case 2:
                    Console.WriteLine("enter the amount you want to withdraw.");
                    double withdraw = Convert.ToDouble(Console.ReadLine());
                    if (b1.Withdraw(withdraw))
                    {
                        Console.WriteLine($"amount: {withdraw} with drwan successfully.");
                    }
                    else
                    {
                        Console.WriteLine("insufficient balance");
                        continue;
                    }
                    break;
                case 3:
                    Console.WriteLine("enter the amount you want to deposit.");
                    double deposit = Convert.ToDouble(Console.ReadLine());
                    if (b1.Deposit(deposit))
                    {
                        Console.WriteLine($"amount: {deposit} deposited successfully.");
                    }
                    else
                    {
                        Console.WriteLine("insufficient or negative amount");
                        continue;
                    }
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("wrong choice");
                    break;
            }
        }
         
    }
}
class BankAccount
{
    public string AccountHolder {  get; }
    public double Balance { get; private set; }
    public BankAccount(string accountHolder, double balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }
    public bool Deposit(double amount)
    {
        if(amount > 0)
        {
            Balance += amount;
            return true;
        }
        return false;
    }
    public bool Withdraw(double amount)
    {
        if((amount <= Balance) && (amount  > 0))
        {
            Balance -= amount;
            return true;
        }
        return false;
    }
    public void DisplayBalance()
    {
        Console.WriteLine("your Balance is: " + Balance);
    }
}
