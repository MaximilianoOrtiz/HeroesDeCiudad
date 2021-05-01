using Heroes.Abstract_Factory.Cuarteles;
using Heroes.Abstract_Factory.FabricaDeHeroes;
using Heroes.Heroes;
using Heroes.Itearator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Proxy
{
    public class MedicoProxy : IResponsable
    {
        HeroeMedico fabricaDeMedicos = new HeroeMedico();

        public MedicoProxy(IResponsable Sucesor) : base(Sucesor) {
        }

        public override void atenderInfartado(IInfartable infartable) {

            ICuartel hospital = fabricaDeMedicos.crearCuartel();
            IResponsable medico = hospital.getPersonal();
            ((Medico)medico).atenderInfartado(infartable);
            hospital.devolverAlICuartl(medico);
        }

    }
}
