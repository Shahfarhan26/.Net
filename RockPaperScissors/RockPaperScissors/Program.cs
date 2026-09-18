
using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine("############################");
        Console.WriteLine("############################");
        Console.WriteLine("    Welcome!Lets Enjoy!     ");
        Console.WriteLine("############################");
        Console.WriteLine("############################");
        string[] ch = new[] { "rock", "paper", "scissors" };
         
        bool n = true;
        while (n)
        {
            string botChoice = ch[random.Next(ch.Length)];
            Console.WriteLine("Rock Paper Scissors\nShoot");
            Console.WriteLine("############################");
            String? a = Console.ReadLine()?.ToLower();
            if ((a == "rock") || (a == "paper") || (a == "scissors"))
            {
                Console.WriteLine("############################");
                Console.WriteLine("player: " + a);
                Console.WriteLine("Computer: " + botChoice);
                Console.WriteLine("############################");
                if (botChoice == a)
                {
                    Console.WriteLine("############################");
                    Console.WriteLine("Draw! Try again!");
                    Console.WriteLine("############################");
                }
                else if(botChoice != a)
                {
                    if ((botChoice == "rock") && (a == "paper")){
                        Console.WriteLine("############################");
                        Console.WriteLine("############################");
                        Console.WriteLine("Player Wins!");
                        Console.WriteLine("############################");
                        Console.WriteLine("############################");
                    }
                    else if ((botChoice == "rock") && (a == "scissors"))
                    {
                        Console.WriteLine("############################");
                        Console.WriteLine("Computer Wins!\nBetter Luck Next Time.");
                        Console.WriteLine("############################");
                    }
                    else if ((botChoice == "scissors") && (a == "paper"))
                    {
                        Console.WriteLine("############################");
                        Console.WriteLine("Computer Wins!\nBetter Luck Next Time");
                        Console.WriteLine("############################");
                    }
                    else if ((botChoice == "scissors") && (a == "rock"))
                    {
                        Console.WriteLine("############################");
                        Console.WriteLine("Player Wins!");
                        Console.WriteLine("############################");
                    }
                    else if ((botChoice == "paper") && (a == "scissors"))
                    {
                        Console.WriteLine("############################");
                        Console.WriteLine("Player Wins!");
                        Console.WriteLine("############################");
                    }
                    else if ((botChoice == "paper") && (a == "rock"))
                    {
                        Console.WriteLine("############################");
                        Console.WriteLine("Computer Wins!\nBetter Luck Next Time");
                        Console.WriteLine("############################");
                    }
                }
            }else
            {
                Console.WriteLine("############################");
                Console.WriteLine("stupid! Choose again between Rockk Paper Scissors only");
                Console.WriteLine("############################");
            }
            Console.WriteLine("############################");
            Console.WriteLine("Would you like to play again? (y/n)");
            string? res = Console.ReadLine()?.ToLower();
            Console.WriteLine("############################");
            if (res == "n")
            {
                n = false;
                Console.WriteLine("############################");
                Console.WriteLine("hope you enjoyed playing");
                Console.WriteLine("############################");
            }
        }
    }
}
