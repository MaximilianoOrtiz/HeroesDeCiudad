using Heroes.Abstract_Factory.Herramientas;
using Heroes.Abstract_Factory.Vehiculos;
using Heroes.Command;
using Heroes.Command.Ordenes;
using Heroes.Itearator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Heroes
{
    public class Policia : IResponsable
    {
        //campos
        IOrden ordenAEjecutar;

        public Policia(IResponsable Sucesor) : base(Sucesor) {
            this.ordenAEjecutar = new DarVozDeAlto();
            this.Herramienta = new Pistola();
            this.vehiculo = new Patrullero();
        }

        public void setordenAEjecutar(IOrden orden) { this.ordenAEjecutar = orden; }
        public override void patrullarCalles(IPatrullable patrullable) {
            if (vehiculo.conducir()) {
                this.Herramienta.usar();
                Console.WriteLine("");
                if (patrullable.hayAlgoFueraDeLoNormal())
                    ordenAEjecutar.ejecutar();
                Console.WriteLine("");
                this.Herramienta.guardar();
            }
            else {
                Console.WriteLine("");
                Console.WriteLine("Lo lamento, no se ah podido llegar a destino");
                Console.WriteLine("");
            }        
        }
    }
}
