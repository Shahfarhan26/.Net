
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("##################################################");
        Console.WriteLine("##################################################");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("              Welcome To Tic-Tac-Toe              ");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("    Hope You Enjoy! May Your Time pass Smoothly   ");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("    Please Choose:                                ");
        Console.WriteLine("..................(Player VS Player){press 1}.....");
        Console.WriteLine("..................(Player VS Computer){press 2}...");
        Console.Write    ("------------------------------------------>>>     ");
        int ch = Convert.ToInt32(Console.ReadLine());
        if (ch != 1 && ch != 2)
        {
            while (ch != 1 && ch != 2)
            {
                Console.WriteLine("    Please enter a VALID choice.                  ");
                Console.WriteLine("    Please Choose:                                ");
                Console.WriteLine("..................(Player VS Player){press 1}.....");
                Console.WriteLine("..................(Player VS Computer){press 2}...");
                Console.Write    ("----------------------------------------->>>      ");
                ch = Convert.ToInt32(Console.ReadLine());
            }
        }
     
        if(ch == 1)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("        You Have Choosen (Player Vs Player)       ");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("--------------------------------------------------");
            Console.Write    ("        Player 1 Please Enter your name: ");
            string? P1 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(P1))
            {
                P1 = "Player 1";
            }
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("--------------------------------------------------");
            Console.Write    ("        Player 2 Please Enter your name:          ");
            string? P2 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(P2))
            {
                P2 = "Player 2";
            }
     
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"        Welcome {P1} = 'X' and {P2} = 'O'        ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"               -------------------               ");
            Console.WriteLine($"               |  1  |  2  |  3  |               ");
            Console.WriteLine($"               -------------------               ");
            Console.WriteLine($"               |  4  |  5  |  6  |               ");
            Console.WriteLine($"               -------------------               ");
            Console.WriteLine($"               |  7  |  8  |  9  |               ");
            Console.WriteLine($"               -------------------               ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            
            Console.WriteLine($"        Enter your choice        ");
            Console.WriteLine("--------------------------------------------------");
        }
        else
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("        You Have Choosen (Player Vs Computer)     ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("        Player 1 Please Enter your name: ");
            string? P1 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(P1))
            {
                P1 = "Player 1";
            }
            Console.WriteLine("--------------------------------------------------");
        }
        

    }
}
