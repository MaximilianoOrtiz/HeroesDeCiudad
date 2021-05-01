using System;
using System.Collections.Generic;
using System.Text;
using Heroes.Abstract_Factory.Cuarteles;
using Heroes.Abstract_Factory.Herramientas;
using Heroes.Abstract_Factory.Vehiculos;
using Heroes.Heroes;
using Heroes.Itearator;

namespace Heroes.Abstract_Factory.FabricaDeHeroes
{
    public class HeroePolicia : IFabricaDeHeroes
    {
        public ICuartel crearCuartel() {
            return Comisaria.getInstance();
            // return new Comisaria();
        }

        public IResponsable crearHeroe() {
            return new Policia(null);
        }

        public IHerramienta crearHerramienta() {
            return new Pistola();
        }

        public IVehiculo crearVehiculo() {
            return new Patrullero();
        }
    }
}
