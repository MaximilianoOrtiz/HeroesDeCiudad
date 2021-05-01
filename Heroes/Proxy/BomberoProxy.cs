using Heroes.Abstract_Factory.Cuarteles;
using Heroes.Abstract_Factory.FabricaDeHeroes;
using Heroes.Abstract_Factory.Herramientas;
using Heroes.Abstract_Factory.Vehiculos;
using Heroes.Itearator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Proxy
{
    public class BomberoProxy : IResponsable
    {
        private HeroeBombero fabricaDeBombero = new HeroeBombero();
       
        public BomberoProxy(IResponsable Sucesor) : base(Sucesor) {
        }

        //sobreescritura del metodo apagarIncendio de la clase IResponsable
        public override void apagarIncendio(Lugar lugar) {

            ICuartel cuartelDeBombero = fabricaDeBombero.crearCuartel();
            Console.WriteLine("Creando Bombero..");
            Console.WriteLine("");
            IResponsable responsable = cuartelDeBombero.getPersonal(); 
            Console.WriteLine("Asignando Estrategia:");
            Console.WriteLine("1) Secuencial");
            Console.WriteLine("2) Escalera");
            Console.WriteLine("3) Espiral");
            Console.WriteLine("");
            Console.WriteLine("seleccione: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion) {
                case 1: { ((Bombero)responsable).setEstrategiaDeApagado(new Secuencial()); break; }
                case 2: { ((Bombero)responsable).setEstrategiaDeApagado(new Escalera()); break; }
                case 3: { ((Bombero)responsable).setEstrategiaDeApagado(new Espiral()); break; }
            }
            Console.WriteLine("Asignado.");
            ((Bombero)responsable).apagarIncendio(lugar);

            cuartelDeBombero.devolverAlICuartl(responsable);

        }
    }
}
