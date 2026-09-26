using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeUsingClasses
{
    internal class Player
    {
        public string Name { get; set; }
        public char Symbol { get; private set; }

        internal Player(string Name, char Symbol)
        {
            this.Name = Name;
            this.Symbol = Symbol;
        }
         
    }
}
