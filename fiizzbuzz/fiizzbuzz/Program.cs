
using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i < 101; i++)
        {
            if ((i % 3) == 0 && (i % 5 ) == 0)
            {
                Console.Write("FizzBuzz\t");
                continue;
            }else
            {
                if ((i % 3) == 0)
                {
                    Console.Write("Fizz\t");
                    continue;
                }
                if ((i % 5) == 0)
                {
                    Console.Write("Buzz\t");
                    continue;
                }
            }
            

            Console.Write(i + "\t");
        }
    }
}
