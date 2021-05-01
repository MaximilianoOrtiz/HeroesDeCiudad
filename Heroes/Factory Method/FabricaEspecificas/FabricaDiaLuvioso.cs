using Heroes.Decorator;
using Heroes.Decorator.Decorados;
using System;

namespace Heroes.Factory_Method
{
    public class FabricaDiaLuvioso : FabricaDeDecorados
    {
        private Random intensidadDeLaLluvia = new Random();
        protected override SectorDecorator crearDecorado(ISector sector) {
            return new DiaLluvioso(sector, intensidadDeLaLluvia.Next(1, 501));
        }

    } 
}