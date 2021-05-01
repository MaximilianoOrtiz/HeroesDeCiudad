using Heroes.Heroes;
using HeroesDeCiudad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Adapter
{
    public class TranseunteAdapter : IInfartable
    {
        Passerby passerby;
        public TranseunteAdapter(Passerby passerby) {
            this.passerby = passerby;
            Console.WriteLine("Soy un passerby");
        }

        public bool estasConciente() {
            return passerby.isConscious();
        }

        public bool estasRespirando() {
            return passerby.isBreathing();
        }

        public bool tieneRidmoCardiaco() {
            return passerby.haveHeartRate();
        }
    }
}
