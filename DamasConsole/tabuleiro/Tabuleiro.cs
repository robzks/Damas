using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace tabuleiro {
    public class Tabuleiro {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas) {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas,colunas];

        }

        public void colocarPeca(Peca peca, Posicao pos) {
            pecas[pos.linha, pos.coluna] = peca;
            peca.posicao = pos;
        }

        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }

     
    }
}
