
using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        Console.WriteLine("fibonacci series: ");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(fibo(i));
        }
        Console.WriteLine("Factorial: ");
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(factorial(i));
        }

    }
    static ulong fibo(int n)
    {
        if (n == 1) { return 1; }
        else if (n == 2) { return 1; }
        else
        {
            return fibo(n - 1) + fibo(n - 2);
        }
    }
    static ulong factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return ((ulong)n * factorial(n - 1));
    }
}
