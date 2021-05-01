using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.State.Estados
{
    public class Vehiculo
    {
        //campo
        protected State estadoDelVehiculo;

        //consructor
        public Vehiculo() {
            estadoDelVehiculo = new Apagado(this);
        }

        //metodos publicos que van a heredar cada uno de los vehiculos en particular
        public void setEstadoDelVehiculo(State estadoNuevoDelVehiculo) {
            this.estadoDelVehiculo = estadoNuevoDelVehiculo;
        }

        public void encender() {
            estadoDelVehiculo.encender();
        }

        public  void apagar() {
            estadoDelVehiculo.apagar();
        }

        public  void acelerar() {
            estadoDelVehiculo.acelerar();
        }

        public  void desacelerar() {
            estadoDelVehiculo.desacelerar();
        }
        public  void frenar() {
            estadoDelVehiculo.frenar();
        }

        public  void arreglar() {
            estadoDelVehiculo.arreglar();
        }

    }
}
