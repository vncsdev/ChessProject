﻿using System;
using ChessProject.Tabuleiro;

namespace ChessProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao P = new Posicao(3, 4);

            Console.WriteLine($"Posição: {P}");
        }
    }
}
