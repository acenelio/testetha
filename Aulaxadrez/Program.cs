using System;
using tabuleiro;
using xadrez;

namespace Aulaxadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            try { 
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.preta), new Posicao(0, 0));
                tab.colocarPeca(new Rei(tab, Cor.preta), new Posicao(0, 0));

                tab.colocarPeca(new Rei(tab, Cor.preta), new Posicao(1, 3));
            tab.colocarPeca(new Torre(tab, Cor.preta), new Posicao(2, 4));


            Tela.imprimirTabuleiro(tab);

        }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message); 
            }

            Console.ReadLine();
        }
    }
}
