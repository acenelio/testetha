﻿namespace tabuleiro
{
   abstract class Peca
    {
        public Posicao posicao { get; set; } 
        public Tabuleiro tab { get; protected set; } 
        public Cor cor { get; protected set; }
        public int QntdMovimentos { get; protected set; }

        public Peca( Tabuleiro tab, Cor cor )
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.QntdMovimentos = 0;
        }

        public void incrementarQntdMovimentos() {
            QntdMovimentos++;
       }
        public void decrementarQntdMovimentos() {
            QntdMovimentos--;
        }

        public bool existemovimentosPossiveis() {
            bool[,] mat = movimentosPossiveis();
            for (int i=0; i<tab.linhas; i++) {
                for (int j = 0; j <tab.colunas; j++) {
                    if (mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos) {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }


        public abstract bool[,] movimentosPossiveis();

    }
}
