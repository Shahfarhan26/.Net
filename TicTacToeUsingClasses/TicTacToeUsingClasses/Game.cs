using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeUsingClasses
{
    internal class Game
    {
        private Player p1;
        private Player p2;
        private Board b1;
        public Game(Player p1, Player p2, Board b1)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.b1 = b1;
        }
        public void Start()
        {
            b1.Display();
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Welcome to Tic Tac Toe");
                int pos;
                if ((i % 2) == 0)
                {
                    Console.WriteLine($"{p2.Name}'s turn. please choose {p2.Symbol} position.");
                    pos = Convert.ToInt32(Console.ReadLine());
                    b1.Position(pos, p2.Symbol);
                    b1.Display();
                    if (b1.CheckWin(p2.Symbol))
                    {
                        Console.WriteLine($"{p2.Name} won");
                        break;
                    }
                    
                }
                else if ((i % 2) != 0)
                {
                    Console.WriteLine($"{p1.Name}'s turn. please choose {p1.Symbol} position.");
                    pos = Convert.ToInt32(Console.ReadLine());
                    b1.Position(pos, p1.Symbol);
                    b1.Display();
                    if (b1.CheckWin(p1.Symbol))
                    {
                        Console.WriteLine($"{p1.Name} won");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("          game has resulted in a Draw             ");
                    }

                }
            }
        }
        
    }
}
