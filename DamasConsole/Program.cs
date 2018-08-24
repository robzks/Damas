using dama;
using System;
using tabuleiro;
using tabuleiro.Excessao;

namespace DamasConsole {
    class Program {
        static void Main(string[] args) {
            //try {
            //    Tabuleiro tab = new Tabuleiro(8, 8);
            //    tab.colocarPeca(new PecaNormal(tab, Cor.Branco), new Posicao(0, 0));
            //    tab.colocarPeca(new PecaNormal(tab, Cor.Branco), new Posicao(0, 1));
            //    tab.colocarPeca(new Dama(tab, Cor.Branco), new Posicao(7, 6));
            //    tab.colocarPeca(new Dama(tab, Cor.Branco), new Posicao(7, 7));
            //    Tela.imprimirTabuleiro(tab);
            //    Console.ReadLine();
            //    Console.Clear();
            //     tab.colocarPeca(new Dama(tab, Cor.Branco), new Posicao(7, 6));
            //    tab.retirarPeca(new Dama(tab, Cor.Branco), new Posicao(7, 7));
            //    Tela.imprimirTabuleiro(tab);
            //}
            //catch (TabuleiroException e) {
            //    Console.WriteLine(e.Message);

            //}

            Posicao p = new PosicaoDama('a', 1).toPosicao();
            Console.WriteLine(p);

            Console.ReadLine();
        }
        
    }
}
