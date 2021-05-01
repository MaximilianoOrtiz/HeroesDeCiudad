using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    class Espiral : IStrategyDeApagadoDeIncendio
    {
        public void apagarIncendio(Lugar lugar, Calle calle) {

                Console.WriteLine("Se ah apagado el fuego de  " + lugar + " con la estrategia ESPIRAL");
        }
    }
}
