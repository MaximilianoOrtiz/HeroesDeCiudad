using Heroes.Decorator;
using System;

namespace Heroes.Factory_Method
{
    public class FabricaDiaDeMuchoCalor : FabricaDeDecorados
    {
        Random temperatura = new Random();
        protected override SectorDecorator crearDecorado(ISector sector) {
            return new DiaDeMuchoCalor(sector, temperatura.Next(30, 46));
        }
    }
}