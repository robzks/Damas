﻿using dama;
using System;
using tabuleiro;
using tabuleiro.Excessao;

namespace DamasConsole {
    class Program {
        static void Main(string[] args) {
           
          
            Partida p = new Partida();
            while (!p.terminada) {
                try {

                    Console.Clear();


                    Tela.imprimirPartida(p);
                Console.Write("Origem: ");
                Posicao pOrigem =   Tela.lerPosicaoDama().toPosicao();
                p.validarPosicaoDeOrigem(pOrigem);
                   
                Console.Clear();
                    bool[,] capturasPossiveis = p.tab.peca(pOrigem).CapturasPossiveis();
                    if (p.essaCorTemCaptura()) {
                        Tela.imprimirTabuleiro(p.tab, capturasPossiveis);
                    }
                    else {
                        bool[,] movimentosPossiveis = p.tab.peca(pOrigem).movimentosPossiveis();
                        Tela.imprimirTabuleiro(p.tab, movimentosPossiveis);
                    }
                  
                   

                Console.Write("Destino: ");
                Posicao pDestino = Tela.lerPosicaoDama().toPosicao();
                    p.validarPosicaoDeDestino(pOrigem, pDestino);

                p.realizaJogada(pOrigem,pDestino);
                }
                catch (TabuleiroException e) {

                    Console.WriteLine(e.Message);


                    Console.ReadLine();

                }
            }
           
            //Posicao p = new PosicaoDama('a', 1).toPosicao();
            //Console.WriteLine(p);

            Console.ReadLine();

        }
        
    }
}
