using Heroes.Accesorios;
using Heroes.Command;
using Heroes.Composite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    class Esquina : IIluminable, IPatrullable
    {
        //campos 
        private List<Farol> faroles;
        private string ubicacion;
        int cantidadDeFaroles;

        public Esquina(string ubicacion, int cantidadDeFaroles) {
            this.ubicacion = ubicacion;
            this.cantidadDeFaroles = cantidadDeFaroles;

            //Se incerta aleatoreamente el estado de las lamparas
            faroles = new List<Farol>();
            Random estadoLampara = new Random();

            for (int i = 0; i < cantidadDeFaroles; i++) {
                faroles.Add(new Farol(estadoLampara.Next(2)));
            }
        }

        public void revisarYCambiarLamparasQuemadas() {

            //revisa las lamparas y en funcion de su estado las cambia
            int lamparasQuemadas = 0;
            foreach (Farol farol in faroles) {
                if (farol.getEstado() == 0)
                    lamparasQuemadas += 1;
            }
            Console.WriteLine("Se ah cambiado " + lamparasQuemadas + " de " + cantidadDeFaroles + " faroles en la esquina " + this.ubicacion);
        }

        //implementacion de la interface Ipatrullable
        public bool hayAlgoFueraDeLoNormal() {
            bool estado = false;
            double probabilidad = 10;
            Random probabilidadAlAzar = new Random();

            if (probabilidadAlAzar.Next() < probabilidad)
                estado = true;
            return estado;
        }

        public override string ToString() {
            return "La esquina";
        }
    }
}
