using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace dama {
    public class PecaNormal : Peca {
        public PecaNormal(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) {

        }
        private bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            if (p == null || p.cor != cor) {
             
                return true;
            }
            return false;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);



            //NOROESTE
            Noroeste(mat, pos);

            //NORDESTE
            Nordeste(mat, pos);


            ////SUDESTE
            Sudeste(mat, pos);

            //SUDOESTE
            Sudoeste(mat, pos);

            return mat;
        }

        private void Sudoeste(bool[,] mat, Posicao pos) {
            pos.definirPosicao(posicao.linha + 1, posicao.coluna - 1);
            if (tab.verificarLimite(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }
        }

        public void Noroeste(bool[,] mat, Posicao pos) {
            pos.definirPosicao(posicao.linha - 1, posicao.coluna - 1);
            if (tab.verificarLimite(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

        }
        public void Nordeste(bool[,] mat, Posicao pos) {
            pos.definirPosicao(posicao.linha - 1, posicao.coluna + 1);
            if (tab.verificarLimite(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;

            }

        }

        public void Sudeste(bool[,] mat, Posicao pos) {
            pos.definirPosicao(posicao.linha + 1, posicao.coluna + 1);
            if (tab.verificarLimite(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }
        }

        public void sudoeste(Posicao pos) {

        }


        public override string ToString() {
            return "P ";
        }

    }
}
