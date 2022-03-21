using ChessProject.Tabuleiro;

namespace ChessProject.Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiroo tab, Cor cor) : base(tab, cor) {}

        public override string ToString()
        {
            return "R";
        }
    }
}
