﻿using tabuleiro.Excessao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace tabuleiro {
    public class Tabuleiro {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas) {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas,colunas];

        }

        public void colocarPeca(Peca peca, Posicao pos) {
            if (temPeca(pos)) {
                throw new TabuleiroException("Já tem peça adicionada na posição: " + pos);
            }
            if (pos.linha < 0  || pos.linha >= linhas || pos.coluna <0 || pos.coluna >= colunas) {
                throw new TabuleiroException("Numero de linha ou coluna execede o tamanho do tabuleiro.");
            }
            else {
                pecas[pos.linha, pos.coluna] = peca;
                peca.posicao = pos;
            }
           
        }

        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }

        private bool temPeca(Posicao pos) {
            if (pecas[pos.linha, pos.coluna] != null ) {
                return true;
            }
            return false;
        }

    }
}
