using Heroes.Command.Ordenes;
using Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Command
{
    class CommandMain
    {
        public static void run() {

            Policia policia = new Policia(null);
            List<IPatrullable> lugaresPatrullables = new List<IPatrullable>();
            Director director = new Director(new BuilderSimple());

            Random probabilidad = new Random();

            //variables para los lugares al azar
            Random puertas = new Random();
            Random sperficie = new Random();
            Random habitantes = new Random();
            Random cantFaroles = new Random();

            Calle calle = new Calle("Pergamino", 100, 4, 60);

            for (int i = 0; i < 15; i++) {
                switch (probabilidad.Next(3)) {
                    case 0: { lugaresPatrullables.Add(new Casa(director, puertas.Next(2, 6), sperficie.Next(15, 60), habitantes.Next(1, 10), calle)); break; }
                    case 1: { lugaresPatrullables.Add(new Plaza(director, "Americas", cantFaroles.Next(5), sperficie.Next(50, 120), calle)); break; }
                    case 2: { lugaresPatrullables.Add(new Esquina("entre Pergamino y Pedriel", cantFaroles.Next(6))); break; }
                }
            }

            for (int j = 0; j < 15; j++) {
                if (j < 5) {
                    policia.setordenAEjecutar(new DarVozDeAlto());
                    policia.patrullarCalles(lugaresPatrullables[j]);
                }
                if (j < 10) {
                    policia.setordenAEjecutar(new PerseguirYArrestar());
                    policia.patrullarCalles(lugaresPatrullables[j]);
                }
                else {
                    policia.setordenAEjecutar(new PedirRefuerzos());
                    policia.patrullarCalles(lugaresPatrullables[j]);
                }
            }

        }
    }
}
