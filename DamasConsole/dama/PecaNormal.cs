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
        private bool podeMover(Posicao pos, Direcao direcao) {

            Peca p = tab.peca(pos);
            if (tab.verificarLimite(pos) && p == null  ) {
                return true;
            }
            return false;
        }

        private bool podeCapturar(Cor pecaAtual, Posicao pos, Direcao direcao) {

            Peca p = tab.peca(pos);
            if (tab.verificarLimite(pos) && p != null && p.cor != pecaAtual ) {
                return true;
            }
            return false;
        }
        public override bool[,] CapturasPossiveis() {
            
            bool[,] mat = new bool[tab.linhas,tab.colunas];

                //NOROESTE
                temPecaCorOposta(mat, Noroeste(mat), Direcao.Noroeste);
                //NORDESTE
                temPecaCorOposta(mat, Nordeste(mat), Direcao.Nordeste);
          
                ////SUDESTE
                temPecaCorOposta(mat, Sudeste(mat), Direcao.Sudeste);
                //SUDOESTE
                temPecaCorOposta(mat, Sudoeste(mat), Direcao.Sudoeste);
                //Sudoeste(mat);
            
            return mat;
        }

        public override bool[,] movimentosPossiveis() {
        
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            if (cor == Cor.Preto) {
                //NOROESTE
                AdicionarPosicaoLivre(mat, Noroeste(mat), Direcao.Noroeste);

                //NORDESTE
                AdicionarPosicaoLivre(mat, Nordeste(mat), Direcao.Nordeste);
            }
            else {
                ////SUDESTE
                AdicionarPosicaoLivre(mat, Sudeste(mat), Direcao.Sudeste);

                //SUDOESTE
                AdicionarPosicaoLivre(mat, Sudoeste(mat), Direcao.Sudoeste);
                //Sudoeste(mat);
            }
            return mat;
        }

        private Posicao Sudoeste(bool[,] mat) {
            Posicao pos = new Posicao(0, 0);
            pos.definirPosicao(new Coordenada(posicao, Direcao.Sudoeste).moverMaisSudoeste());
            return pos;
          
        }
        private Posicao Noroeste(bool[,] mat) {
            Posicao pos = new Posicao(0, 0);
            pos.definirPosicao(new Coordenada(posicao, Direcao.Noroeste).moverMaisNoroeste());
            return pos;
          

        }
        private Posicao Nordeste(bool[,] mat) {
            Posicao pos = new Posicao(0, 0);
            pos.definirPosicao(new Coordenada(posicao, Direcao.Nordeste).moverMaisNordeste());
            return pos;
          
        }
        private Posicao Sudeste(bool[,] mat) {
            Posicao pos = new Posicao(0, 0);
            pos.definirPosicao(new Coordenada(posicao, Direcao.Sudeste).moverMaisSudeste());
            return pos;
          
        }

        private void AdicionarPosicaoLivre(bool[,] mat, Posicao pos, Direcao direcao) {

            if (tab.verificarLimite(pos) && podeMover(pos, direcao)) {
                mat[pos.linha, pos.coluna] = true;
            }
            //else if (temPecaCorOposta(pos, direcao)) {
            //    var posicao = mat[pos.linha, pos.coluna] = true;
            //}
        }

        //private void procurarPecaAdversaria(Posicao pos, Direcao direcao) {
        //    for (int i = 0; i < tab.linhas; i++) {
        //        for (int j = 0; j < tab.colunas; j++) {
        //            if (cor != tab.queCorEhEssaPeca(new Posicao(i, j))) {

        //            }
        //        }

        //    }
        //}

        private void temPecaCorOposta(bool[,] mat, Posicao pos, Direcao direcao) {
           
            if (tab.verificarLimite(pos) && tab.peca(pos)!= null ) {
                if (tab.peca(pos).cor != cor) {
                    
                        var posicao = new Coordenada(pos, direcao).verificarQualPosicaoMover();
                    if (tab.verificarLimite(posicao) && tab.peca(posicao) == null) {
                        mat[posicao.linha, posicao.coluna] = true;
                    }
                        
                    
                   
                }
            }
            
        }

        public override string ToString() {
            return "P ";
        }

    }
}
