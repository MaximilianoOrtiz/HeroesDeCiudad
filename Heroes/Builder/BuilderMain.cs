using System;

namespace Heroes
{
    public class BuilderMain
    {
        public static void run() {
            //Testing
            Console.WriteLine("Creando escenario del testing....");
            Console.WriteLine("");

            //Esenario
            Director directorBuilderSimple = new Director(new BuilderSimple());
            Director directorBuilderFavorable = new Director(new BuilderFavorable());
            Director directorBuilderDesfavorable = new Director(new BuilderDesfavorable());
            Director directorBuilderMixto = new Director(new BuilderMixto());
            Calle calle = new Calle("Pergamino", 100, 4, 60);
            Lugar casa1 = new Casa(directorBuilderSimple, 4, 42, 4, calle);
            Lugar casa2 = new Casa(directorBuilderFavorable, 4, 42, 4, calle);
            Lugar plaza1 = new Casa(directorBuilderDesfavorable, 4, 42, 4, calle);
            Lugar plaza2 = new Casa(directorBuilderMixto, 4, 42, 4, calle);

            IStrategyDeApagadoDeIncendio estrategiaDeApagado = new Secuencial();

            Console.WriteLine("Se han creado: cuatro directores con un constructor diferente cada uno,");
            Console.WriteLine("               cuatro lugares con un director diferente cada uno,");
            Console.WriteLine("               un bombero con estrategia de apagado Secuencial.");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ejecutando...");
            Console.WriteLine("");

            Console.WriteLine("Test Builder Simple...");
            Console.WriteLine("");
            Bombero bombero1 = new Bombero(null,casa1, estrategiaDeApagado);
            bombero1.apagarIncendio();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Presione Enter Para Continuar!");
            Console.ReadKey(true);
            Console.WriteLine("");

            Console.WriteLine("Test Builder Favorable...");
            Console.WriteLine("");
            Bombero bombero2 = new Bombero(null,casa2, estrategiaDeApagado);
            bombero2.apagarIncendio();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Presione Enter Para Continuar!");
            Console.ReadKey(true);
            Console.WriteLine("");

            Console.WriteLine("Test Builder Desafavorable...");
            Console.WriteLine("");
            Bombero bombero3 = new Bombero(null,plaza1, estrategiaDeApagado);
            bombero3.apagarIncendio();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Presione Enter Para Continuar!");
            Console.ReadKey(true);
            Console.WriteLine("");

            Console.WriteLine("Test Builder Mixto...");
            Console.WriteLine("");
            Bombero bombero4 = new Bombero(null,plaza2, estrategiaDeApagado);
            bombero4.apagarIncendio();
            Console.WriteLine("Presione Enter Para Continuar!");
            Console.ReadKey(true);
            Console.WriteLine("");





        }
    }


}