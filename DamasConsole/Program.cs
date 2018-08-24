using dama;
using System;
using tabuleiro;
using tabuleiro.Excessao;

namespace DamasConsole {
    class Program {
        static void Main(string[] args) {
            try {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new PecaNormal(tab, Cor.Branco), new Posicao(0, 0));
                tab.colocarPeca(new PecaNormal(tab, Cor.Branco), new Posicao(0, 1));
                tab.colocarPeca(new Dama(tab, Cor.Preto), new Posicao(7, 6));
                tab.colocarPeca(new Dama(tab, Cor.Preto), new Posicao(7, 7));
                Tela.imprimirTabuleiro(tab);
                Console.WriteLine("Digite a origem da peça ");
              //  var origem = Console.ReadLine().Split("",",");
                Console.WriteLine("Digite a destino da peça ");
                var destino = int.Parse(Console.ReadLine());
                Console.Clear();
                //tab.moverPeca(origem, destino);
                //Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);

            }

            //Posicao p = new PosicaoDama('a', 1).toPosicao();
            //Console.WriteLine(p);

            Console.ReadLine();
        }
        
    }
}
