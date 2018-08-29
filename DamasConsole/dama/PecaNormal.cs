using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace dama {
   public class PecaNormal : Peca {
        public PecaNormal(Tabuleiro tabuleiro, Cor cor) :base(tabuleiro, cor) {

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
            pos.definirPosicao(posicao.linha - 1, posicao.coluna - 1);
            if (tab.verificarLimite(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //NORDESTE
            pos.definirPosicao(posicao.linha - 1, posicao.coluna + 1);
            if (tab.verificarLimite(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            ////SUDESTE
            pos.definirPosicao(posicao.linha + 1, posicao.coluna + 1);
            if (tab.verificarLimite(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //SUDOESTE
            pos.definirPosicao(posicao.linha + 1, posicao.coluna - 1);
            if (tab.verificarLimite(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }



        public override string ToString() {
            return "P ";
        }

    }
}
