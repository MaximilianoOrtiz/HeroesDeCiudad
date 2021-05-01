using Heroes.Abstract_Factory.Cuarteles;
using Heroes.Abstract_Factory.FabricaDeHeroes;
using Heroes.Abstract_Factory.Herramientas;
using Heroes.Abstract_Factory.Vehiculos;
using Heroes.Itearator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class StrategyMain
    {
        public static void rum() {

            Console.WriteLine("------------------------------------");
            Console.WriteLine("             TESTING");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Creando un bombero y calle...");
            Console.WriteLine("");
            Calle calle = new Calle("pedriel", 100, 4, 50);

            Bombero bombero = new Bombero( null);
            bombero.SetNombre("Juan Carlos");
            Director director = new Director(new BuilderSimple());

            Console.WriteLine("Bombero: " + bombero.getNombre());
            Console.WriteLine("Calle: " + calle.getNombre());
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");

            bombero.setLugar(new Casa(director, 4, 20, 5, calle));
            bombero.setEstrategiaDeApagado(new Secuencial());
            bombero.apagarIncendio();

            bombero.setLugar(new Plaza(director, "America", 8, 40, calle));
            bombero.setEstrategiaDeApagado(new Escalera());
            bombero.apagarIncendio();


            //Console.WriteLine("Que desea Apagar:");
            //Console.WriteLine("1) Casa");
            //Console.WriteLine("2) Plaza");
            //Console.Write("eliga: ");
            //int opcion = int.Parse(Console.ReadLine());
            //switch (opcion) {
            //    case 1: { bombero.setLugar(new Casa(director, 4, 20, 5, calle)); break; }
            //    case 2: { bombero.setLugar(new Plaza(director, "America", 8, 40, calle)); break; }
            //}

            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("");
            //Console.WriteLine("Que estrategia desea usar:");
            //Console.WriteLine("1) Secuencial");
            //Console.WriteLine("2) Escalera");
            //Console.WriteLine("3) ESpiral");
            //Console.Write("eliga:");
            //int opcion1 = int.Parse(Console.ReadLine());
            //switch (opcion1) {
            //    case 1: { bombero.setEstrategiaDeApagado(new Secuencial()); break; }
            //    case 2: { bombero.setEstrategiaDeApagado(new Escalera()); break; }
            //    case 3: { bombero.setEstrategiaDeApagado(new Espiral()); break; }
            //}

            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Ejecutando .......");
            //Console.WriteLine("");
            //bombero.apagarIncendio();

        }
    }
}
