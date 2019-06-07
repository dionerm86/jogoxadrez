using System;
using Xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Tabuleiro tab = new Tabuleiro(8, 8);

            //    tab.inserirPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //    tab.inserirPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            //    tab.inserirPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
            //    tab.inserirPeca(new Rei(tab, Cor.Preta), new Posicao(1, 0));

            //    Tela.imprimirTabuleiro(tab);

            //    Console.ReadLine();
            //}

            //catch (TabuleiroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();
         
        }
    }
}
