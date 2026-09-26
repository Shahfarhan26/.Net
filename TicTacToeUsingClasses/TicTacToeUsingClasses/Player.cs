using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeUsingClasses
{
    internal class Player
    {
        public string Name { get; set; }
        public char Symbol { get; private set; }
        public int Score { get; private set; }

        internal Player(string name, char symbol)
        {
            Name = name;
            Symbol = symbol;
        }
        public void AddWin()
        {
            Score++;
        }
    }
}
