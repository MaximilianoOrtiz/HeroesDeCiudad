using Heroes.Decorator;

namespace Heroes.Factory_Method
{
    public class FabricaPAstoSeco : FabricaDeDecorados
    {
        protected override SectorDecorator crearDecorado(ISector sector) {
            return new PastoSeco(sector);
        }
    }
}