using Heroes.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Casa : Lugar, IPatrullable
    {
        private int numeroDePuerta;
        private int supEnMetrosCuadrados;
        private int cantDeHabitantes;
        public Director director { get; set; }



        public Casa(Director director, int numeroDePuerta, int supEnMetrosCuadrados, int cantDeHabitantes, Calle calle) {
            this.numeroDePuerta = numeroDePuerta;
            this.supEnMetrosCuadrados = supEnMetrosCuadrados;
            this.cantDeHabitantes = cantDeHabitantes;
            this.calle = calle;
            if (director == null)
                this.director = new Director(new BuilderSimple());
            else this.director = director;
        }

        //Propiedades

        public int getNumeroDePuerta() { return numeroDePuerta; }
        public void setNumeroDePuerta(int value) { numeroDePuerta = value; }

        public int getSupEnMetrosCuadrados() { return supEnMetrosCuadrados; }
        public void setSupEnMetrosCuadrados(int value) { supEnMetrosCuadrados = value; }

        public int getCantDeHabitantes() { return cantDeHabitantes; }
        public void setCantDeHabitantes(int value) { cantDeHabitantes = value; }

        public override ISector[,] getSectores() {
            int longitud = (int)Math.Round(Math.Sqrt(supEnMetrosCuadrados));
            return director.getSectores(longitud);

            //Sector[,] matriz = new Sector[longitud, longitud];
            //Random r = new Random();

            //for (int i = 0; i < longitud; i++) {
            //    for (int j = 0; j < longitud; j++) {
            //        matriz[i, j] = new Sector(r.Next(101));   //r.Next(101);
            //    }
            //}
            //return matriz;
        }

        public override string ToString() {
            return "la casa";
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
    }
}
