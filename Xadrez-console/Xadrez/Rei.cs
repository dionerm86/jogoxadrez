﻿using tabuleiro;
using System;

namespace Xadrez
{
    class Rei : Peca
    {
        private PartidaDeXadrez partida;

        public Rei(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        {
            this.partida = partida;
        }

        public override string ToString()
        {
            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            return "R";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            // acima
            pos.definirValores(posicao.Linha - 1, posicao.Coluna);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // nordeste
            pos.definirValores(posicao.Linha - 1, posicao.Coluna + 1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // direita
            pos.definirValores(posicao.Linha , posicao.Coluna + 1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // sudeste
            pos.definirValores(posicao.Linha + 1, posicao.Coluna + 1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.definirValores(posicao.Linha + 1, posicao.Coluna);
           
            // abaixo
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // sudoeste
            pos.definirValores(posicao.Linha + 1, posicao.Coluna - 1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // esquerda
            pos.definirValores(posicao.Linha, posicao.Coluna - 1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // noroeste
            pos.definirValores(posicao.Linha - 1, posicao.Coluna - 1);

            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }
    }
}
