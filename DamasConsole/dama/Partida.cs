using DamasConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using tabuleiro.Excessao;

namespace dama {
    class Partida {
       public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
        public bool terminada { get; private set; }

        public Partida() {
            terminada = false;
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branco;
           colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino) {
         Peca peca=  tab.retirarPeca(origem);
            peca.incrementarQteDeMovimentos();
            // Peca pecaCapturada = tab.retirarPeca(destino);
            try {
                tab.colocarPeca(peca, destino);
            }
            catch (TabuleiroException e) {

                Console.WriteLine(e.Message);
            }

        }
        public void validarPosicaoDeOrigem(Posicao origem) {
            if (tab.peca(origem)== null) {
                throw new TabuleiroException("Não existe peça na posição de origem");
            }
            if (jogadorAtual != tab.peca(origem).cor ) {
                throw new TabuleiroException("A peça de origem não é sua!");

            }

            if (!tab.peca(origem).existeMovimentosPossiveis()) {
                throw new TabuleiroException("Não existe movimentos possíveis para esta peça");
            }
        }

        public void validarPosicaoDeDestino(Posicao origem, Posicao destino) {
            if (!tab.peca(origem).podeMoverPara(destino)) {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }
        public void realizaJogada(Posicao origem, Posicao destino) {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        private void mudaJogador() {
            if (jogadorAtual == Cor.Branco) {
                jogadorAtual = Cor.Preto;

            }
            else {
                jogadorAtual = Cor.Branco;
            }
        }

        private void colocarPecas() {


            try {
               
                tab.colocarPeca(new PecaNormal(tab, Cor.Branco), new PosicaoDama('b', 8).toPosicao());
                tab.colocarPeca(new PecaNormal(tab, Cor.Branco), new PosicaoDama('d', 8).toPosicao());
                tab.colocarPeca(new PecaNormal(tab, Cor.Branco), new PosicaoDama('f', 8).toPosicao());
                tab.colocarPeca(new PecaNormal(tab, Cor.Branco), new PosicaoDama('h', 8).toPosicao());

                tab.colocarPeca(new PecaNormal(tab, Cor.Preto), new PosicaoDama('a', 1).toPosicao());
                tab.colocarPeca(new PecaNormal(tab, Cor.Preto), new PosicaoDama('c', 1).toPosicao());
                tab.colocarPeca(new PecaNormal(tab, Cor.Preto), new PosicaoDama('e', 1).toPosicao());
                tab.colocarPeca(new PecaNormal(tab, Cor.Preto), new PosicaoDama('g', 1).toPosicao());
                tab.colocarPeca(new Dama(tab, Cor.Preto), new PosicaoDama('e', 4).toPosicao());
                //tab.moverPeca(origem, destino);
                //Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);

            }


        }
}
}
