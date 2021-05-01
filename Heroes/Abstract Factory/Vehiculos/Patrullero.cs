using Heroes.State.Estados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Abstract_Factory.Vehiculos
{
    public class Patrullero : Vehiculo, IVehiculo {
        Random provabilidadDeQueEjecuteUnaAccion = new Random();
        public bool conducir() {
            Console.WriteLine("Conduciendo Patrullero...");
            Random provabilidadDeQueEjecuteUnaAccion = new Random();
            bool llegoADestino = true;

            this.encender();  // pasa a punto muerto
            this.encenderSirena();
            this.acelerar();    //pasa a marcha lenta
            if (apagoElmotor()) //si apaga el vehiculo , se rompe   
                llegoADestino = false;
            else {
                this.acelerar(); //pasa  a media  marcha
                if (apagoElmotor()) //si apaga el vehiculo , se rompe                  
                    llegoADestino = false;
                else {
                    this.acelerar(); //pasa a toda velocidad
                    if (apagoElmotor()) //si apaga el vehiculo , se rompe 
                        llegoADestino = false;
                    else {
                        this.desacelerar();
                        this.frenar();
                        this.apagar();
                    }
                }
            }
            return llegoADestino;
        }

        public void encenderSirena() {
            Console.WriteLine("Encendiendo sirena del patrullero..");
        } 

    private bool apagoElmotor() {
        if (provabilidadDeQueEjecuteUnaAccion.NextDouble() < 0.1) { // le puse 0  para que se vea bien el funcionamiento
            this.apagar();
            return true;
        }
        return false;
    }
}
}
