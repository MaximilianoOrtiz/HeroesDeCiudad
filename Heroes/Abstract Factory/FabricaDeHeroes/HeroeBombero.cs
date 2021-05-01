using System;
using System.Collections.Generic;
using System.Text;
using Heroes.Abstract_Factory.Cuarteles;
using Heroes.Abstract_Factory.Herramientas;
using Heroes.Abstract_Factory.Vehiculos;
using Heroes.Itearator;

namespace Heroes.Abstract_Factory.FabricaDeHeroes
{
    public class HeroeBombero : IFabricaDeHeroes
    {
        public ICuartel crearCuartel() {
            return CuartelDeBomberos.getInstance();
            //return new CuartelDeBomberos();
        }

        public IResponsable crearHeroe() {
            return new Bombero(null);
        }


        public IHerramienta crearHerramienta() {
            return new Manguera();
        }

        public IVehiculo crearVehiculo() {
            return new Autobomba();
        }
    }
}
