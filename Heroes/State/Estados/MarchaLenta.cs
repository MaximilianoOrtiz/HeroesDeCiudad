using System;

namespace Heroes.State.Estados
{
    public  class MarchaLenta : State
    {
        public MarchaLenta(Vehiculo vehiculo) : base(vehiculo) {
        }

        public override void acelerar() {
            Console.WriteLine("Acelerando hasta media marcha");
            vehiculo.setEstadoDelVehiculo(new MediaMarcha(vehiculo));
        }

        public override void desacelerar() {
            Console.WriteLine("Desacelerando hasta punto muerto");
            vehiculo.setEstadoDelVehiculo(new PuntoMuerto(vehiculo));
        }

        public override void frenar() {
            Console.WriteLine("Desacelerando hasta punto muerto");
            vehiculo.setEstadoDelVehiculo(new PuntoMuerto(vehiculo));
        }

        public override void apagar() {
            Console.WriteLine("Se ah roto el vehiculo por intentar apagarlo llendo a marcha lenta");
            vehiculo.setEstadoDelVehiculo(new Roto(vehiculo));
        }

    }
}