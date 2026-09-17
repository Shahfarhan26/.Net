
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new[] { 49, -23, -1, 2, 3, 156, -4, -78, 5, 6, 7, -3 };
        //how to print array.
        Console.Write("the array before sorting:  ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        //how to find the smalest value.
        int minValue = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < minValue)
            {
                minValue = arr[i];
            }
        }
        Console.WriteLine("\nmin value: " + minValue);

        //how to find the largest value.
        int maxValue = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > maxValue)
            {
                maxValue = arr[i];
            }
        }
        Console.WriteLine("max value: " + maxValue);

        // how to find the average of an array
        int total = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            total += arr[i];
        }
        Console.Write("sum: " + total);
        float average = (float)total / arr.Length;
        Console.WriteLine("sum: " + total);
        Console.Write("average: " + average);

        //how to copy contents of one array into other.
        int[] arr1 = new int[arr.Length];
        for (int i = 0;i < arr.Length; i++)
        {
            arr1[i] = arr[i];
        }
        Console.WriteLine("the contents of first array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("the contents of second array: ");
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write(arr1[i] + " ");
        }
    }
}
