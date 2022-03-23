using System;
using ChessProject.Tabuleiro;
using ChessProject.Xadrez;

namespace ChessProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiroo tab = new Tabuleiroo(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preto), new Posicao(2, 4));

                tab.ColocarPeca(new Torre(tab, Cor.Branco), new Posicao(3, 5));

                Tela.ImprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
