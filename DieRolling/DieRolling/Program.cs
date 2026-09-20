
using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        bool c = true;
        int total = 0;
        while (c)
        {
            Console.Write("enter the number of times you want the die to roll: ");
            int ch = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < ch; i++)
            {
                int roll = r.Next(1, 7);
                total += roll;
                if (i < ch - 1)
                {
                    Console.Write(roll + " + ");
                }
                else
                {
                    Console.Write(roll);
                }
            }
            Console.Write(" = "+ total);
            Console.WriteLine("\nwant do it again? (y/n)");
            string? res = Console.ReadLine()?.ToLower();

            if (res == "n")
            {
                c = false;
            }
        }
    }
}
