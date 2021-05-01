
using Heroes.Factory_Method;
using System;

namespace Heroes 
{
    public class BuilderFavorable : AbstractBuilder
    {
        public override void decorarSector() {
            Sector = FabricaDeDecorados.crearDecorado(FabricaDeDecorados.diaLluvioso, Sector);
        }

    }
}