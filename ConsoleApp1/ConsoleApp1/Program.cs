
using System;

class Program
{
    static void Main(string[] args)
    {
        //insert num into array
        int[] num = new int[5];
        Console.WriteLine("enter five numbers");
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"min: {AnalyzeNumbers(num).min}\nmax: {AnalyzeNumbers(num).max}\naverage: {AnalyzeNumbers(num).average}");
    }
    static (int min, int max, double average) AnalyzeNumbers(int[] num)
    {
        
        //smallest number
        int min = int.MaxValue;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] < min)
            {
                min = num[i];
            }
        }
        // largest number
        int max = int.MinValue;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > max)
            {
                max = num[i];
            }
        }
        //average
        double sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum += num[i];
        }
        return ( min, max, sum/num.Length );
    }
}
