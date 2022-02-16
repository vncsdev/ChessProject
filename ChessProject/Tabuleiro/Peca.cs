﻿namespace ChessProject.Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; }
        public Tabuleiroo Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiroo tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QtdeMovimentos = 0;
        }
    }
}
