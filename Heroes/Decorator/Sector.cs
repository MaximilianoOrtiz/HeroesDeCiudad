using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Sector  : ISector
    {
        private double porcentajeDeAfectacionDelFuego;

        public Sector(double porcentajeDeAfectacionDelFuego) {
            this.porcentajeDeAfectacionDelFuego = porcentajeDeAfectacionDelFuego;
        }

        public double getporcentajeDeAfectacionDelFuego() { return porcentajeDeAfectacionDelFuego; }

        public void mojar(double agua) {
           // Console.Write(" "+ porcentajeDeAfectacionDelFuego);
            porcentajeDeAfectacionDelFuego -= agua;
            if (porcentajeDeAfectacionDelFuego <= 0)
                Console.WriteLine(" -> 0");
            else
                Console.Write(" -> " + porcentajeDeAfectacionDelFuego);
        }
        
        public bool estaApagado() {
            if (porcentajeDeAfectacionDelFuego <= 0)
                return true;
            else return false;
        }

        public override string ToString() {
            return "" + porcentajeDeAfectacionDelFuego   ;
        }
    }
}
