using Heroes.Abstract_Factory.Cuarteles;
using Heroes.Abstract_Factory.FabricaDeHeroes;
using Heroes.Abstract_Factory.Herramientas;
using Heroes.Abstract_Factory.Vehiculos;
using Heroes.Composite;
using Heroes.Itearator;
using Heroes.Template_Method;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Singlenton
{
    public class SinglentonMain
    {
        public static void run() {

            Console.WriteLine("Creando ecenario del testing...");
            Console.WriteLine("");
            Console.WriteLine("Se han creado cuatro fabrica de herores");
            Console.WriteLine("");

            IFabricaDeHeroes bombero = new HeroeBombero();
            IFabricaDeHeroes Policia = new HeroePolicia();
            IFabricaDeHeroes Medico = new HeroeMedico();
            IFabricaDeHeroes Electricista = new HeroeElectricista();

            //Creo 4 cuarteles y le cargo 4 heroes , 4 herramientas y 4 vehiculos

            ICuartel cuartelDeBomberos = crearHeroe(bombero);
            cuartelDeBomberos = crearHeroe(bombero);
            cuartelDeBomberos = crearHeroe(bombero);
            cuartelDeBomberos = crearHeroe(bombero);
            cuartelDeBomberos = crearHeroe(bombero);

            ICuartel Comisaria = crearHeroe(Policia);
            Comisaria = crearHeroe(Policia);
            Comisaria = crearHeroe(Policia);
            Comisaria = crearHeroe(Policia);
            Comisaria = crearHeroe(Policia);

            ICuartel Hospital = crearHeroe(Medico);
            Hospital = crearHeroe(Medico);
            Hospital = crearHeroe(Medico);
            Hospital = crearHeroe(Medico);
            Hospital = crearHeroe(Medico);

            ICuartel CentralElectrica = crearHeroe(Electricista);
            CentralElectrica = crearHeroe(Electricista);
            CentralElectrica = crearHeroe(Electricista);
            CentralElectrica = crearHeroe(Electricista);
            CentralElectrica = crearHeroe(Electricista);

            //Obtengo cuatro personales de cada cuartel

            IResponsable bombero1 = cuartelDeBomberos.getPersonal();
            IResponsable bombero2 = cuartelDeBomberos.getPersonal();
            IResponsable bombero3 = cuartelDeBomberos.getPersonal();
            IResponsable bombero4 = cuartelDeBomberos.getPersonal();

            IResponsable policia1 = Comisaria.getPersonal();
            IResponsable policia2 = Comisaria.getPersonal();
            IResponsable policia3 = Comisaria.getPersonal();
            IResponsable policia4 = Comisaria.getPersonal();

            IResponsable medico1 = Hospital.getPersonal();
            IResponsable medico2 = Hospital.getPersonal();
            IResponsable medico3 = Hospital.getPersonal();
            IResponsable medico4 = Hospital.getPersonal();

            IResponsable electrisista1 = CentralElectrica.getPersonal();
            IResponsable electrisista2 = CentralElectrica.getPersonal();
            IResponsable electrisista3 = CentralElectrica.getPersonal();
            IResponsable electrisista4 = CentralElectrica.getPersonal();

            //mando a la accion a los heroes


            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Ejecuntado con Heroes Bombero");
            Console.WriteLine("---------------------------------------------------------------");

            imprimirHeroeAlctual("Bombero 1");
            ((Bombero)bombero1).setEstrategiaDeApagado(new Secuencial());
            ((Bombero)bombero1).setLugar(new Casa(null, 4, 10, 2, new Calle("pergamono", 100, 4, 30)));
            bombero1.apagarIncendio(((Bombero)bombero1).getLugar());
            ((Bombero)bombero1).setEstrategiaDeApagado(null);
            ((Bombero)bombero1).setLugar(null);
            cuartelDeBomberos.devolverAlICuartl(bombero1);


            imprimirHeroeAlctual("Bombero 2");
            ((Bombero)bombero2).setEstrategiaDeApagado(new Secuencial());
            ((Bombero)bombero2).setLugar(new Casa(null, 4, 10, 2, new Calle("Pedriel", 100, 4, 30)));
            bombero2.apagarIncendio(((Bombero)bombero2).getLugar());
            ((Bombero)bombero2).setEstrategiaDeApagado(null);
            ((Bombero)bombero2).setLugar(null);
            cuartelDeBomberos.devolverAlICuartl(bombero2);


            imprimirHeroeAlctual("Bombero 3");
            ((Bombero)bombero3).setEstrategiaDeApagado(new Secuencial());
            ((Bombero)bombero3).setLugar(new Plaza(null, "Americas", 10, 40, new Calle("pergamono", 100, 4, 30)));
            bombero3.apagarIncendio(((Bombero)bombero3).getLugar());
            ((Bombero)bombero3).setEstrategiaDeApagado(null);
            ((Bombero)bombero3).setLugar(null);
            cuartelDeBomberos.devolverAlICuartl(bombero3);


            imprimirHeroeAlctual("Bombero 4");
            ((Bombero)bombero4).setEstrategiaDeApagado(new Secuencial());
            ((Bombero)bombero4).setLugar(new Casa(null, 4, 10, 2, new Calle("pergamono", 100, 4, 30)));
            bombero4.apagarIncendio(((Bombero)bombero4).getLugar());
            ((Bombero)bombero4).setEstrategiaDeApagado(null);
            ((Bombero)bombero4).setLugar(null);
            cuartelDeBomberos.devolverAlICuartl(bombero4);

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Ejecuntado con Heroe Policia");
            Console.WriteLine("---------------------------------------------------------------");

            imprimirHeroeAlctual("Policia 1");
            policia1.patrullarCalles(new Calle("pergamono", 100, 4, 30));
            Comisaria.devolverAlICuartl(policia1);

            imprimirHeroeAlctual("Policia 2");
            policia2.patrullarCalles(new Calle("Oncativo", 100, 4, 30));
            Comisaria.devolverAlICuartl(policia2);

            imprimirHeroeAlctual("Policia 3");
            policia3.patrullarCalles(new Calle("pergamono", 100, 4, 30));
            Comisaria.devolverAlICuartl(policia3);

            imprimirHeroeAlctual("Policia 4");
            policia4.patrullarCalles(new Calle("pergamono", 100, 4, 30));
            Comisaria.devolverAlICuartl(policia4);


            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Ejecuntado con Heroe Medico");
            Console.WriteLine("---------------------------------------------------------------");

            imprimirHeroeAlctual("Medico 1");
            medico1.atenderInfartado(new Transeunte());
            Hospital.devolverAlICuartl(medico1);

            imprimirHeroeAlctual("Medico 2");
            medico2.atenderInfartado(new Transeunte());
            Hospital.devolverAlICuartl(medico2);

            imprimirHeroeAlctual("Medico 3");
            medico3.atenderInfartado(new Transeunte());
            Hospital.devolverAlICuartl(medico3);

            imprimirHeroeAlctual("Medico 4");
            medico4.atenderInfartado(new Transeunte());
            Hospital.devolverAlICuartl(medico4);

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Ejecuntado con Heroe Electricista");
            Console.WriteLine("---------------------------------------------------------------");

            //creo una manzana en comun para el testing
            Esquina esquina1 = new Esquina("Oncativo y Pedriel", 12);
            Esquina esquina2 = new Esquina("Brochero y Pedriel", 4);
            Esquina esquina3 = new Esquina("Oncativo y Pinochado", 5);
            Esquina esquina4 = new Esquina("O y Pedriel", 12);

            Calle calle1 = new Calle("Pergamino", 100, 4, 50);
            Calle calle2 = new Calle("Brochero", 100, 7, 50);
            Calle calle3 = new Calle("Pedriel", 100, 6, 50);
            Calle calle4 = new Calle("Oncativo", 100, 8, 50);

            Plaza plaza = new Plaza(null, "Americas", 10, 40, calle1);

            lugarCompuesto manzana1 = new lugarCompuesto();
            manzana1.agregarLugar(esquina1);
            manzana1.agregarLugar(esquina2);
            manzana1.agregarLugar(esquina3);
            manzana1.agregarLugar(esquina4);
            manzana1.agregarLugar(calle1);
            manzana1.agregarLugar(calle2);
            manzana1.agregarLugar(calle3);
            manzana1.agregarLugar(calle4);
            manzana1.agregarLugar(plaza);


            //mando a cada electrisista a revisar y cambiar las lamparas quemadas

            imprimirHeroeAlctual("Electricista 1");
            electrisista1.cambiarLamparasQuemadas(manzana1);
            CentralElectrica.devolverAlICuartl(electrisista1);

            imprimirHeroeAlctual("Electricista 2");
            electrisista2.cambiarLamparasQuemadas(manzana1);
            CentralElectrica.devolverAlICuartl(electrisista2);

            imprimirHeroeAlctual("Electricista 3");
            electrisista3.cambiarLamparasQuemadas(manzana1);
            CentralElectrica.devolverAlICuartl(electrisista3);

            imprimirHeroeAlctual("Electricista 4");
            electrisista4.cambiarLamparasQuemadas(manzana1);
            CentralElectrica.devolverAlICuartl(electrisista4);


        }
        public static ICuartel crearHeroe(IFabricaDeHeroes fabricaDeHeroes) {

            ICuartel cuartel = fabricaDeHeroes.crearCuartel();
            IResponsable responsable = fabricaDeHeroes.crearHeroe();
            IVehiculo vehiculo = fabricaDeHeroes.crearVehiculo();
            IHerramienta herramienta = fabricaDeHeroes.crearHerramienta();

            cuartel.agregarVehiculo(vehiculo);
            cuartel.agregarPersonal(responsable);
            cuartel.agregarHerramienta(herramienta);
            return cuartel;
        }

        public static void imprimirHeroeAlctual(string heroe) {
            Console.WriteLine("-------------------------------");
            Console.WriteLine(heroe);
            Console.WriteLine("-------------------------------");
        }
    }
}
