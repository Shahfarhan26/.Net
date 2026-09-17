
using System;

class Program
{
    static void Main(string[] args)
    {
        //number guessing game.
        Console.WriteLine("Welcome TO The Number Guessing Game.\nHope You have Fun.");
        Random random = new Random();
        
        bool Playgame = true;
        while (Playgame)
        {
            int r = random.Next(1, 101);
            Console.WriteLine("Choose A number Between 1 and 100");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != r) {
                if (n > r)
                {
                    Console.WriteLine("You have guessed a high number .Try again");
                }
                else if (n < r)
                {
                    Console.WriteLine("You have guessed a low number .Try again");
                }
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You have won. it was indeed " + r);
            Console.WriteLine("Do You Want To Play Again(Yes/No)");
            string res = Console.ReadLine().ToLower();
            if (res == "yes")
            {
                Playgame = true;
            }
            else
            {
                Playgame = false;
            }
        }
        Console.WriteLine("Thanks for playing!");
    }
}
