namespace tabuleiro {
    public class Peca {
        public Cor cor { get; private set; }
        public Posicao posicao { get; set; }
        public int qteDeJogadas { get; set; }
        public Tabuleiro tab { get; set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor) {
            this.posicao = posicao;
            this.tab = tab;
            qteDeJogadas = 0;

        }
    }

    
}