using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeUsingClasses
{
    internal class Game
    {
        private Player[] players;
        private Board b1;
        public Game(Player p1, Player p2, Board b1)
        {
            players = new Player[] { p1, p2 };
            this.b1 = b1;
        }
        public void Start()
        {
            int round = 1;
            int draws = 0;
            Console.WriteLine("Welcome to Tic Tac Toe");
            Console.WriteLine("How many rounds do you want to play");
            int rounds = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < rounds; j++)
            {
                Console.WriteLine($"round {round} begin. ");
                bool draw = true;
                b1.Display();
                for (int i = 1; i < 10; i++)
                {
                    Player currentPlayer = WhoseTurn(i);
                    Turn(currentPlayer);
                    if (b1.CheckWin(currentPlayer.Symbol))
                    {
                        Console.WriteLine($"{currentPlayer.Name} won");
                        currentPlayer.AddWin();
                        draw = false;
                        break;
                    }
                }
                if (draw)
                {
                    Console.WriteLine("          game has resulted in a Draw             ");
                    draws++;
                }
                b1.Reset();
                round++;
            }
            Console.Write($"{players[0].Name}:\n    Wins: {players[0].Score}\n  Draws: {draws}\n    Loses: {rounds - (players[0].Score + draws)}\n");
            Console.Write($"{players[1].Name}:\n    Wins: {players[1].Score}\n  Draws: {draws}\n    Loses: {rounds - (players[1].Score + draws)}");
        }
        private void Turn(Player p)
        {
            int pos;

            while (true)
            {
                Console.WriteLine($"{p.Name}'s turn. please choose {p.Symbol} position.");
                pos = Convert.ToInt32(Console.ReadLine());

                if (pos < 1 || pos > 9)
                {
                    Console.WriteLine("wrong choice");
                    continue;
                }

                bool moveSuccessful = b1.Position(pos, p.Symbol);

                if (!moveSuccessful)
                {
                    continue;
                }

                b1.Display();
                break;
            }
        }
        private Player WhoseTurn(int i)
        {
            return players[1 - (i % 2)];
        }
        
    }
}
