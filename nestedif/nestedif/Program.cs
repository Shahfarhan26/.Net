using System;
namespace nes
{
    class Pos
    {
        static void Main (string[] args)
        {
            Console.WriteLine("enter your number 1:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your number 2:");
            int b = Convert.ToInt32(Console.ReadLine());
            if ((a == 0) || (b == 0))
            {
                Console.WriteLine("you have entered '0' which is neither '+' nor '-'");
            }
            else
            {
                if (a > 0)
                {
                    if (b > 0)
                    {
                        Console.WriteLine("your number is positive");
                    }
                    else
                        Console.WriteLine("your number is negative");
                }
                else if (a < 0)
                {
                    if (b < 0)
                    {
                        Console.WriteLine("your number is positive");
                    }
                    else
                        Console.WriteLine("your number is negative");
                }
            }
        
             
        }
    }
}