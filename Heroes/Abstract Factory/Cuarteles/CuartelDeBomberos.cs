using System;
using System.Collections.Generic;
using System.Text;
using Heroes.Abstract_Factory.Herramientas;
using Heroes.Abstract_Factory.Vehiculos;
using Heroes.Accesorios;
using Heroes.Itearator;

namespace Heroes.Abstract_Factory.Cuarteles
{
    public class CuartelDeBomberos : ICuartel
    {
        private static CuartelDeBomberos unicoCuartelDeBombero = null;

        private CuartelDeBomberos() {
            vehiculos = new Cola<IVehiculo>();
            herramientas = new Cola<IHerramienta>();
            responsables = new Cola<IResponsable>();
        }

        public static CuartelDeBomberos getInstance() {
            if (unicoCuartelDeBombero == null)
                unicoCuartelDeBombero = new CuartelDeBomberos();
            return unicoCuartelDeBombero;
        }

        public override void agregarHerramienta(IHerramienta herramienta) {
            herramientas.encolar(herramienta);
        }

        public override void agregarPersonal(IResponsable responsable) {

            responsables.encolar(responsable);
        }

        public override void agregarVehiculo(IVehiculo vehiculo) {
            vehiculos.encolar(vehiculo);
        }

        public override IResponsable getPersonal() {

            IHerramienta herramienta = herramientas.desencola();
            IVehiculo vehiculo = vehiculos.desencola();
            IResponsable responsable = responsables.desencola();
            Console.WriteLine("Asignando herramienta...");
            responsable.setHerramienta(herramienta);
            Console.WriteLine("Asignando vehiculo...");
            responsable.setVehiculo(vehiculo);

            return responsable;
        }
    }
}
