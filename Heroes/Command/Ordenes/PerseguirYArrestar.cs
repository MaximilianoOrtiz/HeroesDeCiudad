using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Command.Ordenes
{
    class PerseguirYArrestar : IOrden
    {
        public void ejecutar() {
            Console.WriteLine("Policia: Persiguiendo al delincuente hasta su dectencion");
        }
    }
}
