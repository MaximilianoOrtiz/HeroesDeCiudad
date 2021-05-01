using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    class ObserverMain
    {
        // Calle calle = new Calle(100, 4, 60);

        public static void rum() {

            Calle calle = new Calle("pedriel", 100, 4, 50);
            Bombero bombero = new Bombero(null);
            Director director = new Director(new BuilderSimple());

            Lugar casa1 = new Casa(director, 4, 50, 4, calle);
            Lugar casa2 = new Casa(director, 4, 20, 5, calle);
            Lugar casa3 = new Casa(director, 6, 15, 4, calle);
            Lugar casa4 = new Casa(director, 5, 35, 5, calle);
            Lugar casa5 = new Casa(director, 3, 42, 2, calle);

            Lugar plaza = new Plaza(director, "America", 8, 40, calle);

            casa1.agregarObservador(bombero);
            plaza.agregarObservador(bombero);

            casa1.chispa();
            Console.WriteLine("");
            plaza.chispa();

            casa2.chispa();
        }
    }
}
