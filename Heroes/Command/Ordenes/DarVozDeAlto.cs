using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Command.Ordenes
{
    class DarVozDeAlto : IOrden
    {
        public void ejecutar() {
            Console.WriteLine("Policia: Alto, POLICIA");
        }
    }
}
