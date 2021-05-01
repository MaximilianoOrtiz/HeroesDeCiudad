using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.State.Estados
{
   
    public abstract class State
    {
        //campo
        protected Vehiculo vehiculo;

        //constructor
        public State(Vehiculo vehiculo) {
            this.vehiculo = vehiculo;
        }

        //metodos virtuales que imprimen un texto por defecto 
        public virtual void encender() {
            Console.WriteLine("Sin Efecto");
        }

        public virtual void apagar() {
            Console.WriteLine("Sin Efecto");
        }

        public virtual void acelerar() {
            Console.WriteLine("Sin Efecto");
        }

        public virtual void desacelerar() {
            Console.WriteLine("Sin Efecto");
        }
        public virtual void frenar() {
            Console.WriteLine("Sin Efecto");
        }

        public virtual void arreglar() {
            Console.WriteLine("Sin Efecto");
        }

    }
}
