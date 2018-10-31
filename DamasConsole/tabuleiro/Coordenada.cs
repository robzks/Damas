using System;
using System.Collections.Generic;

namespace tabuleiro {
   public class Coordenada {
        Posicao posicao;
        Direcao direcao;

        public Coordenada(Posicao posicao, Direcao direcao) {
            this.posicao = new Posicao();
            this.posicao.linha = posicao.linha;
            this.posicao.coluna = posicao.coluna;
            this.direcao = direcao;
        }

        public Coordenada(Posicao posicao) {
            this.posicao = new Posicao();
            this.posicao.linha = posicao.linha;
            this.posicao.coluna = posicao.coluna;
        }

        public Coordenada(Posicao posicao1, Posicao posicao2) {
        }

        public Posicao verificarQualPosicaoMover() {
            Posicao pos = new Posicao();
            if (direcao.Equals(Direcao.Nordeste)) {
             pos=  moverMaisNordeste();
            } else if (direcao.Equals(Direcao.Noroeste)) {
              pos =  moverMaisNoroeste();
            } else if ((direcao.Equals(Direcao.Sudeste))) {
              pos =  moverMaisSudeste();
            }else if ((direcao.Equals(Direcao.Sudoeste))) {
              pos =  moverMaisSudoeste();
            }
            return pos;
        }

        public Posicao moverMaisNoroeste() {
            posicao.linha = posicao.linha - 1;
            posicao.coluna = posicao.coluna -1;

            return posicao;
        }

        public Posicao moverMaisSudoeste() {
            posicao.linha = posicao.linha + 1;
            posicao.coluna = posicao.coluna - 1;

            return posicao;
        }

        public Posicao moverMaisNordeste() {
            posicao.linha = posicao.linha - 1;
            posicao.coluna = posicao.coluna + 1;

            return posicao;
        }

        public Posicao moverMaisSudeste() {
            posicao.linha = posicao.linha + 1;
            posicao.coluna = posicao.coluna + 1;

            return posicao;
        }

    }
}
