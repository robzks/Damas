using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace dama {
    class Dama : Peca {
        public Dama(Tabuleiro tabuleiro, Cor cor): base(tabuleiro, cor) {

        }

        public override bool[,] CapturasPossiveis() {
            throw new NotImplementedException();
        }

        public override bool[,] movimentosPossiveis() {
            throw new NotImplementedException();
        }

        //private bool podeMover(Posicao pos) {
        //    Peca p = tab.peca(pos);
        //    if (p == null || p.cor != cor) {
        //        return true;
        //    }
        //    return false;
        //}

        //public override bool[,] movimentosPossiveis() {
        //    bool[,] mat = new bool[tab.linhas,tab.colunas];
        //    Posicao pos = new Posicao(0,0);

        //    //NORDESTE
        //    pos.definirPosicao(posicao.linha - 1, posicao.coluna + 1);
        //    while (tab.verificarLimite(pos) && podeMover(pos)) {
        //        mat[pos.linha, pos.coluna] = true;
        //        if (tab.peca(pos) != null && tab.peca(pos).cor == cor) {
        //            break;
        //        }
        //        pos.linha = pos.linha -1;
        //        pos.coluna = pos.coluna + 1;
        //    }


        //    //NOROESTE
        //    pos.definirPosicao(posicao.linha - 1, posicao.coluna - 1);
        //    while (tab.verificarLimite(pos) && podeMover(pos)) {
        //        mat[pos.linha, pos.coluna] = true;
        //        if (tab.peca(pos) != null && tab.peca(pos).cor == cor) {
        //            break;
        //        }
        //        pos.linha = pos.linha - 1;
        //        pos.coluna = pos.coluna - 1;
        //    }


        //    //SUDESTE
        //    pos.definirPosicao(posicao.linha + 1, posicao.coluna + 1);
        //    while (tab.verificarLimite(pos) && podeMover(pos)) {
        //        mat[pos.linha, pos.coluna] = true;
        //        if (tab.peca(pos) != null && tab.peca(pos).cor == cor) {
        //            break;
        //        }
        //        pos.linha = pos.linha + 1;
        //        pos.coluna = pos.coluna + 1;
        //    }

        //    //SUDOESTE
        //    pos.definirPosicao(posicao.linha + 1, posicao.coluna - 1);
        //    while (tab.verificarLimite(pos) && podeMover(pos)) {
        //        mat[pos.linha, pos.coluna] = true;
        //        if (tab.peca(pos) != null && tab.peca(pos).cor == cor) {
        //            break;
        //        }
        //        pos.linha = pos.linha + 1;
        //        pos.coluna = pos.coluna - 1;
        //    }
        //    return mat;
        //}



        //public override string ToString() {
        //    return "D ";
        //}
    }

    
}
