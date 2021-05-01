using System;

namespace Heroes.Heroes
{
    public class RcpEspañol : Rcp
    {
        protected override void acomodarCabeza() {
            Console.WriteLine("Acomodando la cabeza");
        }

        protected override void comprobarEstado() {
            Console.WriteLine("Comprobando el estado de la conciencia");
        }

        protected override void DescrubirTórax() {
            Console.WriteLine("describriendo torax");
        }

        protected override void eliminarObjetosDeLaboca() {
            Console.WriteLine("revisando y eliminando objetos que se encuentren en la boca");
        }

        protected override void hacerCcompresionesTorácicas() {
            Console.WriteLine("Ejecutando compresioones toracicas en el torax");
        }

        protected override void hacerInsuflacciones() {
            Console.WriteLine("Haciendo Insuflacciones");
        }

        protected override void llamarAmbulancia() {
            Console.WriteLine("Llamando ambulancia");
        }

        protected override void usarElDisfribrilador() {
            Console.WriteLine("Usando el desfribilador");
        }
    }
}