using System;

namespace Heroes.Heroes
{
    public class RcpIngles : Rcp
    {
        protected override void acomodarCabeza() {
            Console.WriteLine("Accommodating the head");

        }

        protected override void comprobarEstado() {
            Console.WriteLine("Checking the state of consciousness");
        }

        protected override void DescrubirTórax() {
            Console.WriteLine("describing thorax");
        }

        protected override void eliminarObjetosDeLaboca() {
            Console.WriteLine("checking and removing objects that are in the mouth");
        }

        protected override void hacerCcompresionesTorácicas() {
            Console.WriteLine("Performing thoracic compressions in the thorax");
        }

        protected override void hacerInsuflacciones() {
            Console.WriteLine("Making insufflations");
        }

        protected override void llamarAmbulancia() {
            Console.WriteLine("calling ambulance");
        }

        protected override void usarElDisfribrilador() {
            Console.WriteLine("Using the defibrillator");
        }
    }
}