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
    public class HeroeElectricista : IFabricaDeHeroes
    {
        public ICuartel crearCuartel() {
            return CentralElectrica.getInstace();
            //return new CentralElectrica();
        }

        public IResponsable crearHeroe() {
            return new Electricista(null);
        }

        public IHerramienta crearHerramienta() {
            return new Buscapolo();
        }

        public IVehiculo crearVehiculo() {
            return new Camioneta();
        }
    }
}
