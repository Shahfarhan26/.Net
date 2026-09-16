using System;
namespace eo
{
    class Deo
    {
        static void Main (string[] args)
        {
            Console.Write("enter your number:\t");
            int n = Convert.ToInt32(Console.ReadLine());
            if ((n % 2) == 0)
            {
                Console.Write($"{n} is even");
            }
            else
                Console.Write($"{n} is odd");
        }
    }
}
