using Heroes.Decorator;
using Heroes.Decorator.Decorados;
using System;

namespace Heroes.Factory_Method
{
    public class FabricaGEnteAsustada : FabricaDeDecorados
    {
        private Random cantDeGente = new Random();
        protected override SectorDecorator crearDecorado(ISector sector) {
           return new GenteAsustada(sector, cantDeGente.Next(1,6));
        }
    }
}