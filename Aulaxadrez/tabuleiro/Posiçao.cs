using System;
using tabuleiro;

namespace tabuleiro
{
    class Posiçao
    {
       
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posiçao(int linha, int coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha
                  + ", "
                  + coluna;
        }
    }
}
