using System;

namespace Heroes.State.Estados
{
    public  class Roto : State
    {
        public Roto(Vehiculo vehiculo) : base(vehiculo) {
        }

        public override void arreglar() {
            Console.WriteLine("Arreglando vehiculo roto");
            vehiculo.setEstadoDelVehiculo(new Apagado(vehiculo));
        }
    }
}