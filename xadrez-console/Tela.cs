using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        //recebe e imprime o tabuleiro
        {
            for (int i=0; i<tab.linhas; i++)
            {
                for (int j=0; j<tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    //se for nulo, imprime -
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                    //se não for nulo, imprime a peça
                }
                Console.WriteLine();
            }
        }
    }
}
