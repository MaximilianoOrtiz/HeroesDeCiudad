using System;

namespace Heroes
{
    public class Director
    {

        public AbstractBuilder Constructor { get; set; }

        public Director(AbstractBuilder constructor) {
            if (constructor == null)
                this.Constructor = new BuilderSimple();
            else
                this.Constructor = constructor;
        }

        public ISector crearSector() {
            Constructor.crearSector();
            Constructor.decorarSector();
            return Constructor.obtenerSector();
        }

        public ISector[,] getSectores(int longitud) {
            ISector[,] matriz = new ISector[longitud, longitud];
            Random r = new Random();

            for (int i = 0; i < longitud; i++) {
                for (int j = 0; j < longitud; j++) {
                    matriz[i, j] = crearSector();   //r.Next(101);
                }
            }
            return matriz;

        }

    }

}