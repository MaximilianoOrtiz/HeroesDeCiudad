using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    class Secuencial : IStrategyDeApagadoDeIncendio
    {
        public void apagarIncendio(Lugar lugar, Calle calle) {

            ISector[,] matrizDelIncendio = lugar.getSectores();
            int anchuraDeMatrizDeIncendio = matrizDelIncendio.GetLength(0);

            for (int fila = 0; fila < anchuraDeMatrizDeIncendio; fila++) {
                for (int columna = 0; columna < anchuraDeMatrizDeIncendio; columna++) {

                    double caudal = calle.getCaudalDeAguaPorMinuto();
                    ISector sectorActual = matrizDelIncendio[fila, columna];
                    Console.Write("(" + fila + " , " + columna + ")  " + sectorActual);

                    while (!sectorActual.estaApagado()) {
                        sectorActual.mojar(caudal);
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("¡¡¡¡¡¡ El fuego de " + lugar + " fue extinguido en su totalidad con la estrategia SECUENCIAL¡¡¡¡¡¡ ");
            Console.WriteLine("");
        }
    }
}
