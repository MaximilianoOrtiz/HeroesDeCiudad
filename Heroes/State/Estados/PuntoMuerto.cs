using System;

namespace Heroes.State.Estados
{
    public class PuntoMuerto : State
    {
        public PuntoMuerto(Vehiculo vehiculo) : base(vehiculo) {
        }

        public override void apagar() {
            Console.WriteLine("Apagando vehiculo");
            vehiculo.setEstadoDelVehiculo(new Apagado(vehiculo));
        }

        public override void acelerar() {
            Console.WriteLine("Acelerando hasta marcha lenta");
            vehiculo.setEstadoDelVehiculo(new MarchaLenta(vehiculo));
        }
    }
}