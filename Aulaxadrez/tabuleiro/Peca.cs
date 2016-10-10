namespace tabuleiro
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

        public abstract bool[,] movimentosPossiveis();

    }
}
