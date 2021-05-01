using System;

namespace Heroes.State.Estados
{
    public  class MediaMarcha : State
    {
        public MediaMarcha(Vehiculo vehiculo) : base(vehiculo) {
        }

        public override void acelerar() {
            Console.WriteLine("Acelerando hasta  toda velocidad");
            vehiculo.setEstadoDelVehiculo(new ATodaVelocidad(vehiculo));
        }
        public override void desacelerar() {
            Console.WriteLine("Desacelerando hasta marcha lenta");
            vehiculo.setEstadoDelVehiculo(new MarchaLenta(vehiculo));
        }

        public override void frenar() {

            Console.WriteLine("Desacelerando hasta punto muerto");
            vehiculo.setEstadoDelVehiculo(new PuntoMuerto(vehiculo));
        }

        public override void apagar() {
            Console.WriteLine("Se ah roto el vehiculo por intentar apagarlo llendo a media marcha");
            vehiculo.setEstadoDelVehiculo(new Roto(vehiculo));
        }
    }
}