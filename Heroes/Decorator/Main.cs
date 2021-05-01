using Heroes.Decorator;
using Heroes.Decorator.Decorados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Main
    {
        public static void rum() {

            ISector sectorDecorado = new GenteAsustada(new ArbolGrande(new Sector(100)),2);

            while (!sectorDecorado.estaApagado()) {

                sectorDecorado.mojar(10);
                Console.WriteLine();
            }
        }
    }
}
