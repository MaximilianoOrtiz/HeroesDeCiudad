using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public interface IStrategyDeApagadoDeIncendio
    {
        void apagarIncendio(Lugar lugar, Calle calle);
    }
}
