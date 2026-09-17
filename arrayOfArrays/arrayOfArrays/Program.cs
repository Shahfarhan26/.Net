
using System;

class Program
{
    static void Main(string[] args)
    {
        //HOW TO WRITE jagged matrix arrays.
        int[][] arr1 = new int[4][]; 
        arr1[0] = new int[5];
        arr1[1] = new int[2];
        arr1[2] = new int[3];
        arr1[3] = new int[7];
        Console.WriteLine("Enter Numbers: ");
        //take input from user.
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr1[i].Length; j++)
            {
                arr1[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Numbers in The Matrix are: ");
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr1[i].Length; j++)
            {
                Console.Write(arr1[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
