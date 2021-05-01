using Heroes.Factory_Method;
using System;

namespace Heroes
{
    public class BuilderMixto : AbstractBuilder
    {
        public override void decorarSector() {
            Random probabilidad = new Random();
            double probabilidadDeDecorar = 0.1;

            if (probabilidad.NextDouble() < probabilidadDeDecorar)
                Sector = FabricaDeDecorados.crearDecorado(FabricaDeDecorados.pastoSeco, Sector);  
            if (probabilidad.NextDouble() < probabilidadDeDecorar)
                Sector = FabricaDeDecorados.crearDecorado(FabricaDeDecorados.arbolGrande, Sector); 
            if (probabilidad.NextDouble() < probabilidadDeDecorar)
                Sector = FabricaDeDecorados.crearDecorado(FabricaDeDecorados.genteAsustada, Sector);  
            if (probabilidad.NextDouble() < probabilidadDeDecorar)
                Sector = FabricaDeDecorados.crearDecorado(FabricaDeDecorados.diaDeMuchoCalor, Sector);  
            if (probabilidad.NextDouble() < probabilidadDeDecorar)
                Sector = FabricaDeDecorados.crearDecorado(FabricaDeDecorados.diaVentoso, Sector);  
            if (probabilidad.NextDouble() < probabilidadDeDecorar)
                Sector = FabricaDeDecorados.crearDecorado(FabricaDeDecorados.diaLluvioso, Sector); 

        }
    }
}