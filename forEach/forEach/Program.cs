
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = new[] { 4, 2, 3 ,1 };
        int min = int.MaxValue;
        int total = 0;
        
        foreach (int i in arr1) {
            if (min > i)
            {
                min = i;
            }
            total += i;
        }
            
        Console.WriteLine("\nmin: " + min);
        Console.WriteLine("average: " + (float)total/arr1.Length);
    }
}
