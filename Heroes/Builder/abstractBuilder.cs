using System;
using Heroes.Decorator;

namespace Heroes
{
    public abstract class AbstractBuilder
    {
        protected ISector Sector { set; get; }

        public void crearSector() {
            Random porcentajeDeAfeccionDeIncendio = new Random();
            Sector = new Sector(porcentajeDeAfeccionDeIncendio.Next(0, 101));
        }

        public ISector obtenerSector() {
            return Sector;
        }

        public abstract void decorarSector();
    }
}