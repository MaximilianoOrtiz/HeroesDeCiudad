using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Accesorios
{
    class Farol
    {
        int estado; // si estado = 1 --> Farol = sano , si estado = 0 --> Farol = quemado

        public Farol(int estado) {
            this.estado = estado;
        }

        public int getEstado() { return estado; }
    }
}
