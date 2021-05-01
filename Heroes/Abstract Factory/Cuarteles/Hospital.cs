using Heroes.Abstract_Factory.Herramientas;
using Heroes.Abstract_Factory.Vehiculos;
using Heroes.Accesorios;
using Heroes.Itearator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Abstract_Factory.Cuarteles
{
    public class Hospital : ICuartel
    {
        private static Hospital unicoHospital = null;
        private Hospital() {
            vehiculos = new Cola<IVehiculo>();
            herramientas = new Cola<IHerramienta>();
            responsables = new Cola<IResponsable>();
        }

        public static Hospital getInstance() {
            if (unicoHospital == null)
                unicoHospital = new Hospital();
            return unicoHospital;
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

            IVehiculo vehiculo = vehiculos.desencola();
            IHerramienta herramienta = herramientas.desencola();
            IResponsable responsable = responsables.desencola();
            responsable.setVehiculo(vehiculo);
            responsable.setHerramienta(herramienta);

            return responsable;
        }
    }
}
