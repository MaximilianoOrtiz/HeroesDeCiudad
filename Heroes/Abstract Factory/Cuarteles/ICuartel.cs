using Heroes.Abstract_Factory.Herramientas;
using Heroes.Abstract_Factory.Vehiculos;
using Heroes.Accesorios;
using Heroes.Itearator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Abstract_Factory.Cuarteles
{
    public abstract class ICuartel
    {
        protected Cola<IVehiculo> vehiculos;
        protected Cola<IHerramienta> herramientas;
        protected Cola<IResponsable> responsables;

        public abstract void agregarVehiculo(IVehiculo vehiculo);
        public abstract void agregarPersonal(IResponsable responsable);
        public abstract void agregarHerramienta(IHerramienta herramienta);

        //Devuelve un Iresponsable con un vehiculo y herramienta seeteado
        public abstract IResponsable getPersonal();

        public void devolverAlICuartl(IResponsable responsable) {
            Console.WriteLine("Devolviendo el heroe a su cuartel");
            agregarVehiculo(responsable.getVehiculo());
            agregarHerramienta(responsable.getHerramienta());
            responsable.setHerramienta(null);
            responsable.setVehiculo(null);
            agregarPersonal(responsable);
        }

    }
}
