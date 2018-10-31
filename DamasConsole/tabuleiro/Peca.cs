using System;

namespace tabuleiro {

    public abstract class Peca {
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

        public bool podeMoverPara(Posicao pos) {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public bool existeMovimentosPossiveis() {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < tab.linhas; i++) {
                for (int j = 0; j < tab.colunas; j++) {
                    if (mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public abstract bool[,] movimentosPossiveis();


        public abstract bool[,] CapturasPossiveis();

        public bool temPecasACapturar() {
            bool temPeca = false;
                var mat = CapturasPossiveis();
            for (int i = 0; i < tab.linhas; i++) {
                for (int j = 0; j < tab.colunas; j++) {
                    if (mat[i, j] ) {
                        return true;
                    }
                   
                }
            }
            return temPeca;

        }


        public void incrementarQteDeMovimentos() {
            qteDeJogadas++;
        }

        internal bool podeMoverParaDepoisDeCapturar(Posicao posicao) {
            return CapturasPossiveis()[posicao.linha, posicao.coluna];
        }
    }

    
}