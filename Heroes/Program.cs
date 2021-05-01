using Heroes.Abstract_Factory;
using Heroes.Adapter;
using Heroes.Chain_of_responsability;
using Heroes.Command;
using Heroes.Composite;
using Heroes.Factory_Method;
using Heroes.Itearator;
using Heroes.Itearator.Denuncias;
using Heroes.Proxy;
using Heroes.Singlenton;
using Heroes.State;
using Heroes.Template_Method;
using System;

namespace Heroes
{
    class Program
    {
        static void Main(string[] args) {

            titulo();
            menuPrincipal();
            int opcion = int.Parse(Console.ReadLine()), cantidadDePatrones = 15, opcionSalir = cantidadDePatrones + 1;

            while (opcion != cantidadDePatrones + 1) {
                switch (opcion) {
                    case 1: {
                            Console.Clear();
                            StrategyMain.rum();
                            Console.WriteLine("");
                            Console.WriteLine("¡Se ha ejecutdo el patron Strategy!");
                            Console.WriteLine("Precione una tecla para continuar, gracias ");
                            Console.ReadKey(true);
                            break;
                        }

                    case 2: {
                            titulo();
                            Console.Clear();
                            ObserverMain.rum();
                            Console.WriteLine("");
                            Console.WriteLine("Se ha ejecutado el patron Observer");
                            Console.WriteLine("Presione una tecla para continuar ");
                            Console.ReadKey(true);
                            break;
                        }
                    case 3: {
                            titulo();
                            Console.Clear();
                            compositeMain.run();
                            Console.WriteLine("");
                            Console.WriteLine("Se ha ejecutado el patron Composite");
                            Console.WriteLine("Presione una tecla para continuar ");
                            Console.ReadKey(true);
                            break;
                        }
                    case 4: {
                            titulo();
                            Console.Clear();
                            DecoratorMain.run();
                            Console.WriteLine("");
                            Console.WriteLine("Se ha ejecutado el patron Decorator");
                            Console.WriteLine("Presione una tecla para continuar ");
                            Console.ReadKey(true);
                            break;
                        }
                    case 5: {
                            titulo();
                            Console.Clear();
                            CommandMain.run();
                            Console.WriteLine("");
                            Console.WriteLine("Se ha ejecutado el patron  Command");
                            Console.WriteLine("Presione una tecla para continuar ");
                            Console.ReadKey(true);
                            break;
                        }
                    case 6: {
                            titulo();
                            Console.Clear();
                            TemplateMethodMain.rum();
                            Console.WriteLine("");
                            Console.WriteLine("Se ha ejecutado el patron template method");
                            Console.WriteLine("Presione una tecla para continuar ");
                            Console.ReadKey(true);
                            break;
                        }
                    case 7: {
                            titulo();
                            Console.Clear();
                            AdapterMain.rum();
                            Console.WriteLine("");
                            Console.WriteLine("Se ha ejecutado el patron Adapter");
                            Console.WriteLine("Presione una tecla para continuar ");
                            Console.ReadKey(true);
                            break;
                        }
                    case 8: {
                            titulo();
                            Console.Clear();
                            FactoryMethodMain.rum();
                            Console.WriteLine("");
                            Console.WriteLine("Se ha ejecutado el Factory Method");
                            Console.WriteLine("Presione una tecla para continuar ");
                            Console.ReadKey(true);
                            break;
                        }
                    case 9: {
                            titulo();
                            Console.Clear();
                            BuilderMain.run();
                            Console.WriteLine("");
                            Console.WriteLine("Se ha ejecutado el Builder");
                            Console.WriteLine("Presione una tecla para continuar ");
                            Console.ReadKey(true);
                            break;
                        }
                    case 10: {
                            titulo();
                            Console.Clear();
                            IteratorMain.run();
                            Console.WriteLine("");
                            Console.WriteLine("Se ha ejecutado el Iterator");
                            Console.WriteLine("Presione una tecla para continuar ");
                            Console.ReadKey(true);
                            break;
                        }
                    case 11: {
                            titulo();
                            Console.Clear();
                            ChainOfResponsabilityMain.run();
                            Console.WriteLine("");
                            Console.WriteLine("Se ha ejecutado el Chain O fResponsability");
                            Console.WriteLine("Presione una tecla para continuar ");
                            Console.ReadKey(true);
                            break;
                        }
                    case 12: {
                            titulo();
                            Console.Clear();
                            AbstractFactoryMain.run();
                            Console.WriteLine("");
                            Console.WriteLine("Se ha ejecutado el Abstract Factory");
                            Console.WriteLine("Presione una tecla para continuar ");
                            Console.ReadKey(true);
                            break;
                        }
                    case 13: {
                            titulo();
                            Console.Clear();
                            SinglentonMain.run();
                            Console.WriteLine("");
                            Console.WriteLine("Se ha ejecutado Singlenton");
                            Console.WriteLine("Presione una tecla para continuar ");
                            Console.ReadKey(true);
                            break;
                        }
                    case 14: {
                            titulo();
                            Console.Clear();
                            ProxyMain.run();
                            Console.WriteLine("");
                            Console.WriteLine("Se ha ejecutado Proxy");
                            Console.WriteLine("Presione una tecla para continuar ");
                            Console.ReadKey(true);
                            break;
                        }
                    case 15: {
                            titulo();
                            Console.Clear();
                            StateMain.run();
                            Console.WriteLine("");
                            Console.WriteLine("Se ha ejecutado State");
                            Console.WriteLine("Presione una tecla para continuar ");
                            Console.ReadKey(true);
                            break;
                        }
                }

                Console.Clear();
                titulo();
                menuPrincipal();
                opcion = int.Parse(Console.ReadLine());
            }

        }

        public static void titulo() {
            Console.Write("********************************************************************************");
            Console.Write("*****                        Héroes de ciudad                              *****");
            Console.Write("********************************************************************************");
        }

        public static void menuPrincipal() {

            Console.Clear();
            titulo();
            Console.WriteLine(" ");
            Console.WriteLine("¿Que patron de diseño desea probar?");
            Console.WriteLine(" ");
            Console.WriteLine("1) Strategy");
            Console.WriteLine("2) Observer");
            Console.WriteLine("3) Composite");
            Console.WriteLine("4) Decoretor ");
            Console.WriteLine("5) Command ");
            Console.WriteLine("6) Template method");
            Console.WriteLine("7) Adapter");
            Console.WriteLine("8) Factory method");
            Console.WriteLine("9) Builder ");
            Console.WriteLine("10) Iterator ");
            Console.WriteLine("11 Chain Of Responsability");
            Console.WriteLine("12) Abstract Factory");
            Console.WriteLine("13) Singlenton");
            Console.WriteLine("14) Proxy");
            Console.WriteLine("15) State");
            Console.WriteLine("16) Salir del Sistema");
            Console.WriteLine(" ");
        }
    }
}


