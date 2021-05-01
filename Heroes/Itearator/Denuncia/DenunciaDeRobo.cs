using Heroes.Command;
using Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Itearator.Denuncia
{
    public class DenunciaDeRobo : IDenuncia
    {
        public IPatrullable Patrullable { get; set; }

        public DenunciaDeRobo(IPatrullable Patrullable) {
            this.Patrullable = Patrullable;
        }

        //implementacion de la interface IDenuncia
        public void atender(IResponsable responsable) {
            responsable.patrullarCalles(Patrullable);
        }
    }
}
