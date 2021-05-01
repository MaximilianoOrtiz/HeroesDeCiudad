using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Abstract_Factory.Herramientas
{
    public class Desfibrilador : IHerramienta
    {
        public void guardar() {
            Console.WriteLine("Guardando desfribrilador");
        }

        public void usar() {
            Console.WriteLine("Usando desfribrilador ");
        }
    }
}
