
using System;

class Program
{
    static void Main(string[] args)
    {
        //cuboid staar pattern.
        for (int i = 0 ; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write("*\t");
            }
            Console.WriteLine("*\t");
        }
        //right angled triangle star pattern.
        Console.Write("\n");
        Console.Write("\n");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
        }
        //triangle star pattern.
        Console.Write("\n");
        Console.Write("\n");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10 - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < i * 2 + 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}
