using System;

namespace Heroes.State.Estados
{
    public  class Apagado : State
    {
        public Apagado(Vehiculo vehiculo) : base(vehiculo) {
        }

        public override void encender() {
            Console.WriteLine("Encenciendo.. Punto muerto ");
            vehiculo.setEstadoDelVehiculo(new PuntoMuerto(vehiculo));
        }

    }
}