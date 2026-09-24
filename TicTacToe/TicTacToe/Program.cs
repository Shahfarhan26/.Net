using System;
class Program
{
    static void Main()
    {
        bool choice = true;
        Greet();
        Dash(2);
        string P1 = Name1();
        Dash(2);
        string P2 = Name2();
        Dash(2);
        Start(P1, P2);
        PvP(P1, P2);
        Dash(2);
        while (choice)
        {
            Console.WriteLine("Do you want to play again? (Y/N)");
            Dash(2);
            string? ch = Console.ReadLine()?.ToLower();
            if (ch == "n")
            {
                choice = false;
            }
            else if ((ch != "n") && (ch != "y"))
            {
                Console.WriteLine("wrong choice. choose again.");
                Dash(2);
                ch = Console.ReadLine()?.ToLower();
            }
            else
            {
                Start(P1, P2);
                PvP(P1, P2);
                Dash(2);
            }
        } 
    }
    static void Greet()
    {
        Dash(4);
        Console.WriteLine("              Welcome To Tic-Tac-Toe              ");
        Dash(1);
        Console.WriteLine("    Hope You Enjoy! May Your Time pass Smoothly   ");
        Dash(1);
    }
    static void PvP(string P1, string P2)
    {
        
        int i = 1;
        string[] xo = [ "","1", "2", "3", "4", "5", "6", "7", "8", "9" ];
        int ox;
        bool exit = true;
        bool IfWin = false;
        while (exit)
        {
            if ((i % 2) == 0)
            {
                Console.WriteLine($"{P2}'s turn. please choose 'O' position.");
                ox = Convert.ToInt32(Console.ReadLine());
                
                if ((xo[ox] == "X") || (xo[ox] == "O") || (ox < 1) || (ox > 9))
                {
                    Console.WriteLine("wrong choice. already filled");
                    continue;
                }
                Dash(2);
                Console.WriteLine($"   {P2} has choosen 'O' at {xo[ox]}th position   ");
                xo[ox] = "O";
                Display(xo);
                IfWin = CheckWn("O", P2, xo);
                if (IfWin)
                {
                    Dash(2);
                    Console.WriteLine("          Thanks for Playing             ");
                    Dash(2);
                    exit = false;
                }
            }
            else if ((i % 2) != 0)
            {
                Console.WriteLine($"{P1}'s turn. please choose 'X' position.");
                ox = Convert.ToInt32(Console.ReadLine());
                if ((xo[ox] == "X") || (xo[ox] == "O") || (ox < 1) || (ox > 9))
                {
                    Console.WriteLine("wrong choice. already filled");
                    continue;
                }
                Dash(2);
                Console.WriteLine($"     {P1} has choosen 'X' at {xo[ox]}th position ");
                xo[ox] = "X";
                Display(xo);
                IfWin = CheckWn("X", P1, xo);
                if (IfWin)
                {
                    Dash(2);
                    Console.WriteLine("          Thanks for Playing             ");
                    Dash(2);
                    exit = false;
                }
            }
            i++;
            if (i == 10 && (!IfWin))
            {
                Dash(2);
                Console.WriteLine("          game has resulted in a Draw             ");
                Dash(2);
                exit = false;
            }
        }
    }
    static bool CheckWn(string a,string P, string[] xo)
    {
        
        if (((xo[1] == a) && (xo[2] == a) && (xo[3] == a)) ||
                    ((xo[4] == a) && (xo[5] == a) && (xo[6] == a)) ||
                    ((xo[7] == a) && (xo[8] == a) && (xo[9] == a)) ||
                    ((xo[1] == a) && (xo[4] == a) && (xo[7] == a)) ||
                    ((xo[2] == a) && (xo[5] == a) && (xo[8] == a)) ||
                    ((xo[3] == a) && (xo[6] == a) && (xo[9] == a)) ||
                    ((xo[1] == a) && (xo[5] == a) && (xo[9] == a)) ||
                    ((xo[3] == a) && (xo[5] == a) && (xo[7] == a)))
        {
            Dash(2);
            Console.WriteLine($"                   {P} wins                     ");
            Dash(2);
            return  true;
        }
        return false;
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
    static string Name1()
    {
        Console.Write("        Player 1 Please Enter your name: ");
        string? P1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(P1))
        {
            P1 = "Player 1";
        }
        return P1;
    }
    static string Name2()
    {
        Console.Write("        Player 2 Please Enter your name: ");
        string? P2 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(P2))
        {
            P2 = "Player 2";
        }
        return P2;
    }
    static void Start(string P1, string P2)
    {
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

    }
    static void Dash(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
