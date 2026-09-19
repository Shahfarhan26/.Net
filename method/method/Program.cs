
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("whose the birthday boy/girl?");
        string? name = Console.ReadLine();
        singHappyBirthday(name);

        Console.WriteLine("sum of 1 + 2 is " + add(1, 2));
        Console.WriteLine("sum of 1 + 2 + 3 is " + add(1, 2,3));
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
    static int add(int a, int b)
    {
        return a + b;
    }
    static int add(int a, int b, int c) {  return a + b + c; } 

}
