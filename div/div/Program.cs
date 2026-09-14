using System;
namespace div
{
    class D
    {
        static void Main(string[] args)
        {
            int a = 17, b = 4;
            int quotient = a / b;
            int remainder = a % b;
            int o = b * quotient + remainder;
            Console.WriteLine("quotient is " + quotient + "\nremainder is " + remainder);
            Console.WriteLine(o);
        }
    }
}