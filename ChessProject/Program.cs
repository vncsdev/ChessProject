using System;
using ChessProject.Tabuleiro;
using ChessProject.Xadrez;

namespace ChessProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());
        }
    }
}
