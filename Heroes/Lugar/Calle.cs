using Heroes.Accesorios;
using Heroes.Command;
using Heroes.Composite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Calle : IIluminable, IPatrullable
    {
        //campos
        private List<Farol> faroles;
        private string nombre;
        private int longitudEnMetros, cantidadDeFarolas, caudalDeAguaPorMinuto;

        public Calle(string nombre, int longitudEnMetros, int cantidadDeFarolas, int caudalDeAguaPorMinuto) {
            this.setLongitudEnMetros(longitudEnMetros);
            this.cantidadDeFarolas = cantidadDeFarolas;
            this.caudalDeAguaPorMinuto = caudalDeAguaPorMinuto;
            this.nombre = nombre;

            //Se incerta aleatoreamente el estado de las lamparas
            faroles = new List<Farol>();
            Random estadoLampara = new Random();

            for (int i = 0; i < cantidadDeFarolas; i++) {
                faroles.Add(new Farol(estadoLampara.Next(2)));
            }
        }

        //propiedades
        public string getNombre() { return nombre; }
        public void setNombre(string value) { nombre = value; }

        public int getLongitudEnMetros() { return longitudEnMetros; }
        public void setLongitudEnMetros(int value) { longitudEnMetros = value; }

        public int getCaudalDeAguaPorMinuto() { return caudalDeAguaPorMinuto; }
        public void setCaudalDeAguaPorMinuto(int value) { caudalDeAguaPorMinuto = value; }


        //implementacion de la interface IIluminable
        public void revisarYCambiarLamparasQuemadas() {

            //revisa las lamparas y en funcion de su estado las cambia
            int lamparasQuemadas = 0;
            foreach (Farol farol in faroles) {
                if (farol.getEstado() == 0)
                    lamparasQuemadas += 1;
            }

            Console.WriteLine("Se ah cambiado " + lamparasQuemadas + " de " + cantidadDeFarolas + " faroles de la calle " + nombre);
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
