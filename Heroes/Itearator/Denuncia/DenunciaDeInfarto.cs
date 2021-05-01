using Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Itearator.Denuncia
{
    public class DenunciaDeInfarto :IDenuncia
    {
        public IInfartable Infartable { get; set; }

        public DenunciaDeInfarto(IInfartable infartable) {
            this.Infartable = infartable;
        }
        
        //implementacion de la interface IDenuncia
        public void atender(IResponsable responsable) {
            responsable.atenderInfartado(Infartable);
        }
    }
}

