using Heroes.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Factory_Method
{
    public abstract class FabricaDeDecorados
    {
        public const int pastoSeco = 1, arbolGrande = 2, diaDeMuchoCalor = 3, diaLluvioso = 4, diaVentoso = 5, genteAsustada = 6;
        protected abstract SectorDecorator crearDecorado(ISector sector);
        public static SectorDecorator crearDecorado(int queDecorado, ISector sector) {

            FabricaDeDecorados fabrica = null;

            switch (queDecorado) {
                case pastoSeco: { fabrica = new FabricaPAstoSeco(); break; }
                case arbolGrande: { fabrica = new FabricaArbolGrande(); break; }
                case diaDeMuchoCalor: { fabrica = new FabricaDiaDeMuchoCalor(); break; }
                case diaLluvioso: { fabrica = new FabricaDiaLuvioso(); break; }
                case diaVentoso: { fabrica = new FabricaDiaVentoso(); break; }
                case genteAsustada: { fabrica = new FabricaGEnteAsustada(); break; }
            }
            return fabrica.crearDecorado(sector);
        }
    }
}
