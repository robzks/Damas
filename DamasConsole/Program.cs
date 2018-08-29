using dama;
using System;
using tabuleiro;
using tabuleiro.Excessao;

namespace DamasConsole {
    class Program {
        static void Main(string[] args) {

            Partida p = new Partida();
            while (!p.terminada) {
                Console.Clear();
                Tela.imprimirTabuleiro(p.tab);
                Console.WriteLine();
                Console.Write("Origem: ");
                Posicao pOrigem =   Tela.lerPosicaoDama().toPosicao();

                Console.Clear();
                bool[,] movimentosPossiveis = p.tab.peca(pOrigem).movimentosPossiveis();
                Tela.imprimirTabuleiro(p.tab,movimentosPossiveis);

                Console.Write("Destino: ");
                Posicao pDestino = Tela.lerPosicaoDama().toPosicao();

                p.executaMovimento(pOrigem,pDestino);
                
            }
          
            //Posicao p = new PosicaoDama('a', 1).toPosicao();
            //Console.WriteLine(p);

            Console.ReadLine();
        }
        
    }
}
