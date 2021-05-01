using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Itearator
{
    class IteratorDenunciaPorMostrador : Iterator
    {
        private int contador;
        private IDenuncia denuncia;

        public IteratorDenunciaPorMostrador(IDenuncia denuncia) {
            this.denuncia = denuncia;
            contador = 0;
        }

        public bool hastNext() {
            return contador < 1;
        }

        public object next() {
            contador++;
            return denuncia;
        }
    }
}
