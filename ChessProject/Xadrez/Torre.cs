using ChessProject.Tabuleiro;

namespace ChessProject.Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiroo tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "T";
        }
    }
}
