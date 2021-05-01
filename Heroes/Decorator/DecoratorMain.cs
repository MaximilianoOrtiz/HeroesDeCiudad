using Heroes.Decorator;
using Heroes.Decorator.Decorados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    class DecoratorMain
    {

        public static void run() {


            Console.WriteLine("Creando plaza...");
            Console.WriteLine("-----------------------------------------------------------");

            Director director = new Director(new BuilderMixto());

            Calle calle = new Calle("pedriel", 100, 4, 50);
            Lugar plaza = new Plaza(director, "America", 8, 40, calle);
            Console.WriteLine("");

            Console.WriteLine("Apagando incendio en la Plaza con diferentes dificultades");
            Console.WriteLine("");

            IStrategyDeApagadoDeIncendio estrategiaDeApagado1 = new Secuencial();
            IStrategyDeApagadoDeIncendio estrategiaDeApagado2 = new Escalera();
            IStrategyDeApagadoDeIncendio estrategiaDeApagado3 = new Espiral();

            Bombero bombero = new Bombero(null,plaza, estrategiaDeApagado1);

            bombero.apagarIncendio();

        }


    }
}
