
using System;

class Program
{
    static void Main()
    {
        Greet();
        PvP();
        
    }
    static void Greet()
    {
        Dash(4);
        Console.WriteLine("              Welcome To Tic-Tac-Toe              ");
        Dash(1);
        Console.WriteLine("    Hope You Enjoy! May Your Time pass Smoothly   ");
        Dash(1);
    }
  
    static void PvP()
    {
        Dash(2);
        Console.Write("        Player 1 Please Enter your name: ");
        string? P1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(P1))
        {
            P1 = "Player 1";
        }
        Dash(2);
        Console.Write("        Player 2 Please Enter your name:          ");
        string? P2 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(P2))
        {
            P2 = "Player 2";
        }

        Dash(2);
        Console.WriteLine($"        Welcome {P1} = 'X' and {P2} = 'O'        ");
        Dash(2);
        Console.WriteLine($"               -------------------               ");
        Console.WriteLine($"               |  1  |  2  |  3  |               ");
        Console.WriteLine($"               -------------------               ");
        Console.WriteLine($"               |  4  |  5  |  6  |               ");
        Console.WriteLine($"               -------------------               ");
        Console.WriteLine($"               |  7  |  8  |  9  |               ");
        Console.WriteLine($"               -------------------               ");
        Dash(2);
        int i = 1;
        string[] xo = [ "","1", "2", "3", "4", "5", "6", "7", "8", "9" ];
        int ox;
        while (i < 10)
        {
            if ((i % 2) == 0)
            {
                Console.WriteLine($"{P2}'s turn. please choose 'O' position.");
                ox = Convert.ToInt32(Console.ReadLine());
                if ((xo[ox] == "X") || (xo[ox] == "O"))
                {
                    Console.WriteLine("wrong choice. already filled");
                    continue;
                }
                Dash(2);
                Console.WriteLine($"   {P2} has choosen 'O' at {xo[ox]}th position   ");
                xo[ox] = "O";
                Display(xo);
                
            }else if((i % 2) != 0)
            {
                Console.WriteLine($"{P1}'s turn. please choose 'X' position.");
                ox = Convert.ToInt32(Console.ReadLine());
                if ((xo[ox] == "X") || (xo[ox] == "O"))
                {
                    Console.WriteLine("wrong choice. already filled");
                    continue;
                }
                Dash(2);
                Console.WriteLine($"     {P1} has choosen 'X' at {xo[ox]}th position ");
                xo[ox] = "X";
                Display(xo);
            }
            i++;

        }
    }
    static void Display(string[] xo)
    {
        Dash(2);

        Console.WriteLine($"                -------------------");

        Console.WriteLine($"                |  {xo[1]}  |  {xo[2]}  |  {xo[3]}  |");

        Console.WriteLine($"                -------------------");

        Console.WriteLine($"                |  {xo[4]}  |  {xo[5]}  |  {xo[6]}  |");

        Console.WriteLine($"                -------------------");

        Console.WriteLine($"                |  {xo[7]}  |  {xo[8]}  |  {xo[9]}  |");

        Console.WriteLine($"                -------------------");
        Dash(2);
    }
    static void Dash(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
