using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; } 
        public Tabuleiro tab { get; protected set; } 
        public Cor cor { get; protected set; }
        public int QuantidadedeMovimentos { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor )
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.QuantidadedeMovimentos = 0;
        }
    }
}
