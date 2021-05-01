using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Abstract_Factory.Herramientas
{
    public class Buscapolo : IHerramienta
    {
        public void guardar() {
            Console.WriteLine("Guardando buscapolo");
        }

        public void usar() {
            Console.WriteLine("Usando buscapolo");
        }
    }
}
