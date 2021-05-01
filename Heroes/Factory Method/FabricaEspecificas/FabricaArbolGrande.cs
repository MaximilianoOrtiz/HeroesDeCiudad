using Heroes.Decorator;

namespace Heroes.Factory_Method
{
    public class FabricaArbolGrande : FabricaDeDecorados
    {
        protected override SectorDecorator crearDecorado(ISector sector) {
            return new ArbolGrande(sector);
        }
    }
}