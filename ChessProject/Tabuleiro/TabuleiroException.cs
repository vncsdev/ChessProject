using System;

namespace ChessProject.Tabuleiro
{
    internal class TabuleiroException : Exception 
    {
        public TabuleiroException(string msg) : base(msg) { }
    }
}
