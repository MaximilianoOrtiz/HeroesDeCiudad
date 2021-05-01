using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Itearator
{
    public class DenunciaDeIncendio : IDenuncia
    {
        public Lugar Lugar { get; set; }

        public DenunciaDeIncendio(Lugar lugar) {
            this.Lugar = lugar;
        }

        //implementacion de la interface IDenuncia
        public void atender(IResponsable responsable) {
            
            responsable.apagarIncendio(Lugar);
        }
    }
}

