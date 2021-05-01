using Heroes.Abstract_Factory.Cuarteles;
using Heroes.Abstract_Factory.Herramientas;
using Heroes.Abstract_Factory.Vehiculos;
using Heroes.Itearator;

namespace Heroes.Abstract_Factory.FabricaDeHeroes
{
    public interface IFabricaDeHeroes
    {
        IResponsable crearHeroe();
        IVehiculo crearVehiculo();
        IHerramienta crearHerramienta();
        ICuartel crearCuartel();
    }
}

