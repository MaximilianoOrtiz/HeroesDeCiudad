using Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Observer
{
    public interface IObservado
    {
        void agregarObservador(IObservador observador);
        void quitarIObservador(IObservador observador);
        void notificar();
    }
}
