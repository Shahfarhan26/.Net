
using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(fibo(i));
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
}
