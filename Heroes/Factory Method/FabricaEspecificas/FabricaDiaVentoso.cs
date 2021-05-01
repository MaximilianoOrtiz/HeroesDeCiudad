using Heroes.Decorator;
using Heroes.Decorator.Decorados;
using System;

namespace Heroes.Factory_Method
{
    public class FabricaDiaVentoso : FabricaDeDecorados
    {
        private Random velocidadDelViento =new Random();
        protected override SectorDecorator crearDecorado(ISector sector) {
            return new DiaVentoso(sector, velocidadDelViento.Next(80,251)); ;
        }
    }
}