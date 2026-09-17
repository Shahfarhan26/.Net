
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new [] {49,23,1,2,3,56,4,78,5,6,7,3};
        //how to print array.
        Console.Write("the array befor sorting:  ");
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
        Console.Write("\n" + minValue);

    }
}
