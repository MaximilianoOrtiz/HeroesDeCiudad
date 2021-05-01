using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Abstract_Factory.Herramientas
{
    public class Manguera : IHerramienta
    {
        public void guardar() {
            Console.WriteLine("Guardando manguera"); 
        }

        public void usar() {
            Console.WriteLine("Usando manguera para apagar el incendio");
            
        }
    }
}
