using Heroes.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Heroes
{
    public interface IObservador
    {
        void actualizar(IObservado lugarObservado);
    }
}
