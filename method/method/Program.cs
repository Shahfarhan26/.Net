
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("whose the birthday boy/girl?");
        string? name = Console.ReadLine();
        singHappyBirthday(name);
    }
    static void singHappyBirthday(string name)
    {
        Console.WriteLine("Happy Birthday to you");
        Console.WriteLine("Happy Birthday to you");
        Console.WriteLine("Happy Birthday to  " + name);
        Console.WriteLine("Happy Happy Birthday to you");
        Console.WriteLine("May GOD bless you");
        Console.WriteLine("May GOD bless you");
        Console.WriteLine("Happy Birthday to you");
    }
}
