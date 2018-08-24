using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace dama {
   public class PecaNormal : Peca {
        public PecaNormal(Tabuleiro tabuleiro, Cor cor) :base(tabuleiro, cor) {

        }

        public override string ToString() {
            return "P ";
        }

    }
}
