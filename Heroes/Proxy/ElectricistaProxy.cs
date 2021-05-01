using Heroes.Abstract_Factory.Cuarteles;
using Heroes.Abstract_Factory.FabricaDeHeroes;
using Heroes.Composite;
using Heroes.Heroes;
using Heroes.Itearator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Proxy
{
    public class ElectricistaProxy : IResponsable
    {
        HeroeElectricista fabricaDeElectricistas = new HeroeElectricista();

        public ElectricistaProxy(IResponsable Sucesor) : base(Sucesor) {
        }

        public override void cambiarLamparasQuemadas(IIluminable lugarIluminable) {
            ICuartel centralElectrica = fabricaDeElectricistas.crearCuartel();
            IResponsable electricista = centralElectrica.getPersonal();
            ((Electricista)electricista).cambiarLamparasQuemadas(lugarIluminable);
            centralElectrica.devolverAlICuartl(electricista);
        }
    }
}
