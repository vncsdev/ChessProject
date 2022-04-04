namespace ChessProject.Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; }
        public Tabuleiroo Tab { get; protected set; }

        public Peca(Tabuleiroo tab, Cor cor)
        {
            Posicao = null;
            Tab = tab;
            Cor = cor;
            QtdeMovimentos = 0;
        }

        public void IncrementarQteMovimentos()
        {
            QtdeMovimentos++;
        }
    }
}