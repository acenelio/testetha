using System;
using tabuleiro;

namespace Aulaxadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;
            p = new Posicao (1, 2);

            Console.WriteLine("Posicao = " + p);

            Console.ReadLine();
        }
    }
}
