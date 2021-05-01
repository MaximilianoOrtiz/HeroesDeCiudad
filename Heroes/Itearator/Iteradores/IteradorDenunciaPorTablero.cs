using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Itearator
{
    public class IteradorDenunciaPorTablero : Iterator
    {
        int posicionActual;
        List<IDenuncia> denuncias;

        public IteradorDenunciaPorTablero(List<IDenuncia> denuncias) {
            posicionActual = 0;
            this.denuncias = denuncias;
        }

        //implementaceion de la interface Iterator 
        public bool hastNext() {
            return posicionActual < denuncias.Count;
        }

        public object next() {
            int posiciónAux = posicionActual;
            posicionActual++;
            return denuncias[posiciónAux];
        }
    }
}
