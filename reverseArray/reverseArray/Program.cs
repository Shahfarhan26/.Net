
using System;

class Program
{
    static void Main(string[] args)
    {
        
        /*int[] arr1 = create();
        print(arr1);
        int[] arr2 = rev(arr1);
        print(arr2);
        */
    }
    static int[] create()
    {
        Console.WriteLine("enter number of elements to put in the array.");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = new int[n]; 
        Console.WriteLine("Enter elements: ");
        for (int i = 0; i < n; i++)
        {
            arr1[i] =   Convert.ToInt32(Console.ReadLine());
        }
        return arr1;
    }
    /*one way by creating another array
    static int[] rev(int[] arr)
    {
        int[] rev = new int[arr.Length];
        Console.WriteLine("Your array has been reversed");
        for(int i = 0;i < arr.Length; i++)
        {
            rev[i] = arr[arr.Length - 1 - i];
        }
        return rev;
    }*/
    
    static void print(int[] arr1)
    {
        Console.Write("Your Array is as follows: ");
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write(" " + arr1[i]);
        }
        Console.WriteLine();
    }

}
