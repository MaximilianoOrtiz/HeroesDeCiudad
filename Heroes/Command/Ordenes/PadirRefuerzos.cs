using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Command.Ordenes
{
    class PedirRefuerzos : IOrden
    {
        public void ejecutar() {
            Console.WriteLine("Policia: Avisando y pidiendo Refuerzos");
        }
    }
}
