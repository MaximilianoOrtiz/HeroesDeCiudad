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
    public class HeroeMedico : IFabricaDeHeroes
    {
        public ICuartel crearCuartel() {
            return Hospital.getInstance();
            // return new Hospital();
        }

        public IResponsable crearHeroe() {
            return new Medico(null, null, null);
        }

        public IHerramienta crearHerramienta() {
            return new Desfibrilador();
        }

        public IVehiculo crearVehiculo() {
            return new Ambulancia();
        }
    }
}
