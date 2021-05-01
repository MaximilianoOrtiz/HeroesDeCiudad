using System;

namespace Heroes.Heroes
{
  public abstract class Rcp
    {
        public void ejecutarProtocoloRcpPrimeraImplementacion(IInfartable infartable) {
            int cantidadDeIntentos = 0;
            this.eliminarObjetosDeLaboca();
            this.comprobarEstado();
            if (!infartable.estasConciente()) {
                this.llamarAmbulancia();
                this.DescrubirTórax();
                this.acomodarCabeza();
                while (cantidadDeIntentos < 5 && !infartable.estasRespirando() ) {
                    this.hacerCcompresionesTorácicas();
                    this.hacerInsuflacciones();
                    if (!infartable.tieneRidmoCardiaco())
                        this.usarElDisfribrilador();
                    cantidadDeIntentos++;
                }
                if(cantidadDeIntentos==5)
                    Console.WriteLine("Se ah intentado reanimar a la victima 5 veces... Lamentamos su fallecimiento. ");
                else
                    Console.WriteLine("La victima a vuelto a respirar.... Esperando ambulancia");
            }
            else
                Console.WriteLine("La victima se encuentra conciente");

        }




        public void ejecutarProtocoloRcpSegundaImplementacion(IInfartable infartable) {
           
            this.eliminarObjetosDeLaboca();
            this.comprobarEstado();
            if (!infartable.estasConciente()) {
                this.llamarAmbulancia();
                this.DescrubirTórax();
                this.acomodarCabeza();
                while (!infartable.estasRespirando()) {
                    this.hacerCcompresionesTorácicas();
                    this.hacerInsuflacciones();
                    if (!infartable.tieneRidmoCardiaco())
                        this.usarElDisfribrilador();
                    
                }
                Console.WriteLine("La victima a vuelto a respirar.... Esperando ambulancia");
            }
            else
                Console.WriteLine("La victima se encuentra conciente");
        }




        abstract protected void comprobarEstado();
        abstract protected void eliminarObjetosDeLaboca();
        abstract protected void llamarAmbulancia();
        abstract protected void DescrubirTórax();
        abstract protected void acomodarCabeza();
        abstract protected void hacerCcompresionesTorácicas();
        abstract protected void hacerInsuflacciones();
        abstract protected void usarElDisfribrilador();
    }
}