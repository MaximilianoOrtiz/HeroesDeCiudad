using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Abstract_Factory.Herramientas
{
    public class Pistola : IHerramienta
    {
        public void guardar() {
            Console.WriteLine("Guardando pistola");
        }

        public void usar() {
            Console.WriteLine("Usando Pistola");
        }
    }
}
