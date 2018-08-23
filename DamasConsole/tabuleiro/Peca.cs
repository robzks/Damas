﻿namespace tabuleiro {
    public class Peca {
        public Cor cor { get; private set; }
        public Posicao posicao { get; set; }
        public int qteDeJogadas { get; set; }
        public Tabuleiro tab { get; set; }

        public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            qteDeJogadas = 0;

        }
    }

    
}