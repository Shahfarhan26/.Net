
using System;

class Program
{
    static void Main(string[] args)
    {
        greet();
        int ch = choice();
     
        if(ch == 1)
        {
            pvp(ch);
        }
        else
        {
            cvp(ch);
        }
        

    }
    static void greet()
    {
        Console.WriteLine("##################################################");
        Console.WriteLine("##################################################");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("              Welcome To Tic-Tac-Toe              ");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("    Hope You Enjoy! May Your Time pass Smoothly   ");
        Console.WriteLine("--------------------------------------------------");
    }
    static int choice()
    {
        Console.WriteLine("    Please Choose:                                ");
        Console.WriteLine("..................(Player VS Player){press 1}.....");
        Console.WriteLine("..................(Player VS Computer){press 2}...");
        Console.Write("------------------------------------------>>>     ");
        int ch = Convert.ToInt32(Console.ReadLine());
        if (ch != 1 && ch != 2)
        {
            while (ch != 1 && ch != 2)
            {
                Console.WriteLine("    Please enter a VALID choice.                  ");
                Console.WriteLine("    Please Choose:                                ");
                Console.WriteLine("..................(Player VS Player){press 1}.....");
                Console.WriteLine("..................(Player VS Computer){press 2}...");
                Console.Write("----------------------------------------->>>      ");
                ch = Convert.ToInt32(Console.ReadLine());
            }
        }
        return ch;
    }
    static void pvp(int ch)
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("        You Have Choosen (Player Vs Player)       ");
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("--------------------------------------------------");
        Console.Write("        Player 1 Please Enter your name: ");
        string? P1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(P1))
        {
            P1 = "Player 1";
        }
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("--------------------------------------------------");
        Console.Write("        Player 2 Please Enter your name:          ");
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
        int i = 1;
        string[] xo = new[] { "","1", "2", "3", "4", "5", "6", "7", "8", "9" };
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
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"   {P2} has choosen 'O' at {xo[ox]}th position   ");
                xo[ox] = "O";
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine($"                -------------------");

                Console.WriteLine($"                |  {xo[1]}  |  {xo[2]}  |  {xo[3]}  |");

                Console.WriteLine($"                -------------------");

                Console.WriteLine($"                |  {xo[4]}  |  {xo[5]}  |  {xo[6]}  |");

                Console.WriteLine($"                -------------------");

                Console.WriteLine($"                |  {xo[7]}  |  {xo[8]}  |  {xo[9]}  |");

                Console.WriteLine($"                -------------------");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("--------------------------------------------------");
            }else if((i % 2) != 0)
            {
                Console.WriteLine($"{P1}'s turn. please choose 'X' position.");
                ox = Convert.ToInt32(Console.ReadLine());
                if ((xo[ox] == "X") || (xo[ox] == "O"))
                {
                    Console.WriteLine("wrong choice. already filled");
                    continue;
                }
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine($"     {P1} has choosen 'X' at {xo[ox]}th position ");
                xo[ox] = "X";
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine($"                -------------------");

                Console.WriteLine($"                |  {xo[1]}  |  {xo[2]}  |  {xo[3]}  |");

                Console.WriteLine($"                -------------------");

                Console.WriteLine($"                |  {xo[4]}  |  {xo[5]}  |  {xo[6]}  |");

                Console.WriteLine($"                -------------------");

                Console.WriteLine($"                |  {xo[7]}  |  {xo[8]}  |  {xo[9]}  |");

                Console.WriteLine($"                -------------------");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("--------------------------------------------------");
            }
            i++;

        }
    }
    static void cvp(int ch)
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
