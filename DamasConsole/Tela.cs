using dama;
using System;
using tabuleiro;

namespace DamasConsole {
    class Tela {

        public static void imprimirTabuleiro(Tabuleiro tab) {
            for (int i = 0; i < tab.linhas; i++) {
                Console.Write(8 - i +" ");
                for (int j = 0; j < tab.colunas; j++) {
                    if (tab.peca(i, j) == null) {
                        Console.Write("-  ");
                    }
                    else {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine("  A  B  C  D  E  F  G  H");
            Console.WriteLine();
        }

        public static void imprimirPeca(Peca peca) {
            if (peca.cor == Cor.Preto) {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            else {
                Console.Write(peca);
            }

            
        }

        public static PosicaoDama lerPosicaoDama() {
           
            var origem = Console.ReadLine();
            char oColuna = origem[0];
            int oLinha = int.Parse (origem[1]+ "");
          

            return new PosicaoDama(oColuna, oLinha);
        }
    }
}
