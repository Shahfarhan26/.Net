
using System;
using TicTacToeUsingClasses;

class Program
{
    static void Main(string[] args)
    {
        Player p1 = new Player("trex",'X');
        Player p2 = new Player("dee", 'O');
        Board b1 = new Board();
        Game game = new Game(p1, p2, b1);

        game.Start();

    }
}
