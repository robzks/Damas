

namespace tabuleiro {
  public class Posicao {
        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }

        public Posicao() {

        }
        public void definirPosicao(Posicao pos) {
            this.linha = pos.linha;
            this.coluna = pos.coluna;
        }

        public override string ToString() {
            return "" + this.linha + ", " + this.coluna; 
        }
    }
}
