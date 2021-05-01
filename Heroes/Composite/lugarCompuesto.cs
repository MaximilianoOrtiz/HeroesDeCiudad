using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Composite
{
   public class lugarCompuesto : IIluminable
    {
        List<IIluminable> lugaresIluminables;

        public lugarCompuesto() {
            lugaresIluminables = new List<IIluminable>();
        }

        public void agregarLugar(IIluminable lugarIluminado) {
            lugaresIluminables.Add(lugarIluminado);
        }

        public void revisarYCambiarLamparasQuemadas() {

            foreach (IIluminable lugarIluminado in lugaresIluminables) {
                if (lugarIluminado is lugarCompuesto)
                   // Console.WriteLine("");
                    Console.WriteLine("soy composite");

                lugarIluminado.revisarYCambiarLamparasQuemadas();  
            }
        }
    }
}
