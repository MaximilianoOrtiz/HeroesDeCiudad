using Heroes.Composite;
using Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Itearator.Denuncia
{
    class DenunciaDeLamparaQuemada : IDenuncia
    {
        IIluminable Iluminable { get; set; }

        public DenunciaDeLamparaQuemada(IIluminable Iluminable) {
            this.Iluminable = Iluminable;
        }

        //implementacion de la interface IDenuncia
        public void atender(IResponsable responsable) {
            responsable.cambiarLamparasQuemadas(Iluminable);
        }
    }
}
