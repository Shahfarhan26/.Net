using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeUsingClasses
{
    internal class Board
    {
        
        private char[] xo = [' ', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
        
        public void Display()
        {
            Console.WriteLine($"                -------------------");

            Console.WriteLine($"                |  {xo[1]}  |  {xo[2]}  |  {xo[3]}  |");

            Console.WriteLine($"                -------------------");

            Console.WriteLine($"                |  {xo[4]}  |  {xo[5]}  |  {xo[6]}  |");

            Console.WriteLine($"                -------------------");

            Console.WriteLine($"                |  {xo[7]}  |  {xo[8]}  |  {xo[9]}  |");

            Console.WriteLine($"                -------------------");
        }
        public bool Position(int pos,char symbol)
        {
            if (pos > 0 && pos < 10)
            {
                if (xo[pos] != 'X' && xo[pos] != 'O')
                {
                    if (symbol == 'X' || symbol == 'O')  
                    {
                        xo[pos] = symbol;
                        return true;
                    }
                }
            }
                Console.WriteLine("wrong choice");
                return false;    
        }
        public bool CheckWin(char symbol)
        {
            if (((xo[1] == symbol) && (xo[2] == symbol) && (xo[3] == symbol)) ||
                    ((xo[4] == symbol) && (xo[5] == symbol) && (xo[6] == symbol)) ||
                    ((xo[7] == symbol) && (xo[8] == symbol) && (xo[9] == symbol)) ||
                    ((xo[1] == symbol) && (xo[4] == symbol) && (xo[7] == symbol)) ||
                    ((xo[2] == symbol) && (xo[5] == symbol) && (xo[8] == symbol)) ||
                    ((xo[3] == symbol) && (xo[6] == symbol) && (xo[9] == symbol)) ||
                    ((xo[1] == symbol) && (xo[5] == symbol) && (xo[9] == symbol)) ||
                    ((xo[3] == symbol) && (xo[5] == symbol) && (xo[7] == symbol)))
            {
                
                return true;
            }
            return false;
        }
        public void Reset()
        {
            xo = [' ', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
        }
    }
}
