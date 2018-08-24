using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace dama {
    class Dama : Peca {
        public Dama(Tabuleiro tabuleiro, Cor cor): base(tabuleiro, cor) {

        }
        public override string ToString() {
            return "D ";
        }
    }

    
}
