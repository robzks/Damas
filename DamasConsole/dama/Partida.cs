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
        public bool temCaptura { get; set; }
        public bool jogadaCaptura { get; set; }
        private HashSet<Peca> pecas = new HashSet<Peca>();
        private HashSet<Peca> capturadas = new HashSet<Peca>();


        public Partida() {
            temCaptura = false;
            terminada = false;
            jogadaCaptura = false;
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branco;
           colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino) {

            Peca peca=  tab.retirarPeca(origem);
            peca.incrementarQteDeMovimentos();
            Peca pecaCapturada = tab.capturarPeca(origem, destino);
            
            try {
                tab.colocarPeca(peca, destino);
            }
            catch (TabuleiroException e) {

                Console.WriteLine(e.Message);
            }
            if (pecaCapturada != null) {
                capturadas.Add(pecaCapturada);
                jogadaCaptura = true;
            }

        }

        //public bool[,] verificarPossiveisCapturas() {
        //    bool[,] aux = new bool[tab.linhas, tab.colunas];
        //    foreach (var item in pecas) {
                
                     

        //    }

        //}
        //public bool temLanceObrigatorio() {
        //    return false;
        //}

        public void validarPosicaoDeOrigem(Posicao origem) {
            if (tab.peca(origem)== null) {
                throw new TabuleiroException("Não existe peça na posição de origem");
            }
            if (jogadorAtual != tab.peca(origem).cor ) {
                throw new TabuleiroException("A peça de origem não é sua!");

            }

            if (essaCorTemCaptura()) {
                if (!essaPecaTemCaptura(origem)) {
                    throw new TabuleiroException("Existem capturar obrigatorias.");
                }

            }

            //if (!tab.peca(origem).existeMovimentosPossiveis()) {
            //    throw new TabuleiroException("Não existe movimentos possíveis para esta peça");
            //}
        }

        public void validarPosicaoDeDestino(Posicao origem, Posicao destino) {
            if (!tab.peca(origem).podeMoverPara(destino) && !tab.peca(origem).podeMoverParaDepoisDeCapturar(destino)) {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }
    public void realizaJogada(Posicao origem, Posicao destino) {
           
                executaMovimento(origem, destino);
                        
            turno++;
            mudaJogador();
          
        }

        public bool essaPecaTemCaptura(Posicao origem) {
            return tab.essaPecaTemCaptura(origem);
        }

        public bool essaCorTemCaptura() {
            if (tab.temPecasACapturar(jogadorAtual)) {
                return true;
            }
            return false;
        }

        private void mudaJogador() {
            temCaptura = essaCorTemCaptura();
            if (!temCaptura && !jogadaCaptura) {
                if (jogadorAtual == Cor.Branco) {
                    jogadorAtual = Cor.Preto;

                }
                else {
                    jogadorAtual = Cor.Branco;
                }
               
            }
            jogadaCaptura = false;

        }

        public HashSet<Peca> pecasCapturadas(Cor cor) {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca item in capturadas) {
                if (item.cor == cor) {
                    aux.Add(item);
                }
            }
            return aux;
        }

        public HashSet<Peca> pecasEmJogo(Cor cor) {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca item in pecas) {
                if (item.cor == cor) {
                    aux.Add(item);
                }
            }
            aux.ExceptWith(pecasCapturadas(cor));
            return aux;
        }

        private void colocarNovasPecas(char coluna, int linha, Peca peca) {
            tab.colocarPeca(peca, new PosicaoDama(coluna, linha).toPosicao());
            pecas.Add(peca);
        }

        private void colocarPecas() {


            try {


                colocarNovasPecas('b', 8, new PecaNormal(tab, Cor.Branco));
                colocarNovasPecas('d', 8, new PecaNormal(tab, Cor.Branco));
                colocarNovasPecas('f', 8, new PecaNormal(tab, Cor.Branco));
                colocarNovasPecas('h', 8, new PecaNormal(tab, Cor.Branco));
                colocarNovasPecas('a', 7, new PecaNormal(tab, Cor.Branco));
                colocarNovasPecas('c', 7, new PecaNormal(tab, Cor.Branco));
                colocarNovasPecas('e', 7, new PecaNormal(tab, Cor.Branco));
                colocarNovasPecas('g', 7, new PecaNormal(tab, Cor.Branco));
                colocarNovasPecas('b', 6, new PecaNormal(tab, Cor.Branco));
                colocarNovasPecas('d', 6, new PecaNormal(tab, Cor.Branco));
                colocarNovasPecas('f', 6, new PecaNormal(tab, Cor.Branco));
                colocarNovasPecas('h', 6, new PecaNormal(tab, Cor.Branco));

                colocarNovasPecas('a', 1, new PecaNormal(tab, Cor.Preto));
                colocarNovasPecas('c', 1, new PecaNormal(tab, Cor.Preto));
                colocarNovasPecas('e', 1, new PecaNormal(tab, Cor.Preto));
                colocarNovasPecas('g', 1, new PecaNormal(tab, Cor.Preto));
                //colocarNovasPecas('b', 2, new PecaNormal(tab, Cor.Preto));
                //colocarNovasPecas('d', 2, new PecaNormal(tab, Cor.Preto));
                //colocarNovasPecas('f', 2, new PecaNormal(tab, Cor.Preto));
                //colocarNovasPecas('h', 2, new PecaNormal(tab, Cor.Preto));
                colocarNovasPecas('a', 3, new PecaNormal(tab, Cor.Preto));
                colocarNovasPecas('c', 3, new PecaNormal(tab, Cor.Preto));
                colocarNovasPecas('e', 5, new PecaNormal(tab, Cor.Preto));
                colocarNovasPecas('g', 3, new PecaNormal(tab, Cor.Preto));


                //tab.moverPeca(origem, destino);
                //Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);

            }


        }
}
}
