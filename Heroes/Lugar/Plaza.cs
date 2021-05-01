using Heroes.Accesorios;
using Heroes.Command;
using Heroes.Composite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Plaza : Lugar, IIluminable, IPatrullable
    {

        private List<Farol> faroles;
        string nombre;
        int cantidadDeFaroles;
        int superficieEnMetrosCuadrados;
        public Director Director { get; set; } 

        public Plaza(Director director, string nombre, int cantFaroles, int superficie, Calle calle) {
            this.nombre = nombre;
            cantidadDeFaroles = cantFaroles;
            this.superficieEnMetrosCuadrados = superficie;
            this.calle = calle;
            if (director == null)
                this.Director = new Director(new BuilderSimple());
            else this.Director = director;

            //Se incerta aleatoreamente el estado de las lamparas
            faroles = new List<Farol>();
            Random estadoLampara = new Random();

            for (int i = 0; i < cantidadDeFaroles; i++) {
                faroles.Add(new Farol(estadoLampara.Next(2)));
            }
        }

        //devuelve una matriz  con sectores decorados al azar   
        public override ISector[,] getSectores() {
            int longitud = (int)Math.Round(Math.Sqrt(superficieEnMetrosCuadrados));

            return Director.getSectores(longitud);

            //ISectorComponete[,] matriz = new ISectorComponete[longitud, longitud];
            //Random r = new Random();

            //for (int i = 0; i < longitud; i++) {
            //    for (int j = 0; j < longitud; j++) {
            //        matriz[i, j] = new Sector(r.Next(101)); 
            //        matriz[i, j] = decorarSector((Sector)matriz[i, j]);   
            //    }
            //}
            //return matriz;
        }

        //implementacion de la interface IIluminable
        public void revisarYCambiarLamparasQuemadas() {
            //revisa las lamparas y en funcion de su estado las cambia
            int lamparasQuemadas = 0;
            foreach (Farol farol in faroles) {
                if (farol.getEstado() == 0)
                    lamparasQuemadas += 1;
            }
            Console.WriteLine("Se ah cambiado " + lamparasQuemadas + " de " + cantidadDeFaroles + " faroles en la Plaza " + this.nombre);
        }

        //implementacion de la interface Ipatrullable
        public bool hayAlgoFueraDeLoNormal() {
            bool estado = false;
            double probabilidad = 1;
            Random probabilidadAlAzar = new Random();

            if (probabilidadAlAzar.Next() > probabilidad)
                estado = true;
            return estado;
        }

        public override string ToString() {
            return "la plaza";
        }

    }
}
