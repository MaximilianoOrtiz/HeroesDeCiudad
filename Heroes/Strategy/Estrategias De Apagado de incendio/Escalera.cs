using System;
using System.Collections.Generic;
using System.Text;


namespace Heroes
{
    class Escalera : IStrategyDeApagadoDeIncendio {

        public void apagarIncendio(Lugar lugar, Calle calle) {

            ISector[,] matrizDelIncendio = lugar.getSectores();
            int anchuraDeMatrizDeIncendio = matrizDelIncendio.GetLength(0);

            for (int fila = 0; fila < anchuraDeMatrizDeIncendio; fila++) {
                if (fila % 2 == 0) {
                    for (int nuevaColumna = anchuraDeMatrizDeIncendio - 1; nuevaColumna >= 0; nuevaColumna--) {
                        apagarSector(matrizDelIncendio, fila, nuevaColumna, calle);
                    }
                }
                else {
                    for (int columna = 0; columna < anchuraDeMatrizDeIncendio; columna++) {
                        apagarSector(matrizDelIncendio,fila,columna,calle);
                    }
                }

            }
            Console.WriteLine("");
            Console.WriteLine("¡¡El fuego de " + lugar + " fue extinguido en su totalidad con la estrategia ESCALERA¡¡ ");
        }

        private static void apagarSector(ISector[,] matrizDelIncendio, int fila, int columna, Calle calle) {
            double caudal = calle.getCaudalDeAguaPorMinuto();
            ISector sectorActual = matrizDelIncendio[fila, columna];
            Console.Write("(" + fila + " , " + columna + ")  " + sectorActual);
            while (!sectorActual.estaApagado()) {
                sectorActual.mojar(caudal);
            }
        }

    }
}
