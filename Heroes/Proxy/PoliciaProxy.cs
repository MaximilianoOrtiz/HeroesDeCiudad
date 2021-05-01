using Heroes.Abstract_Factory.Cuarteles;
using Heroes.Abstract_Factory.FabricaDeHeroes;
using Heroes.Command;
using Heroes.Heroes;
using Heroes.Itearator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Proxy
{
    class PoliciaProxy : IResponsable
    {
        HeroePolicia fabricaDePolicias = new HeroePolicia();

        public PoliciaProxy(IResponsable Sucesor) : base(Sucesor) {
        }

        public override void patrullarCalles(IPatrullable patrullable) {
            ICuartel comisaria = fabricaDePolicias.crearCuartel();
            IResponsable policia = comisaria.getPersonal();
            ((Policia)policia).patrullarCalles(patrullable);
            comisaria.devolverAlICuartl(policia);
        }

    }
}
