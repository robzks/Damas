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
        private int turno;
        private Cor jogadorAtual;
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
           // peca.incrementarQteDeMovimentos();
           // Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(peca, destino);
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
              
                //tab.moverPeca(origem, destino);
                //Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);

            }


        }
}
}
