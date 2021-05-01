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

namespace Heroes.Abstract_Factory
{
    class AbstractFactoryMain
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

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Ejecuntado con Heroe Bombero");
            Console.WriteLine("---------------------------------------------------------------");

            ICuartel CuartelDeBombero = crearHeroe(bombero);
            IResponsable bomberoResponsable = CuartelDeBombero.getPersonal();
            ((Bombero)bomberoResponsable).setEstrategiaDeApagado(new Secuencial());
            ((Bombero)bomberoResponsable).setLugar(new Casa(null, 4, 10, 2, new Calle("pergamono", 100, 4, 30)));
            bomberoResponsable.apagarIncendio(((Bombero)bomberoResponsable).getLugar());
            ((Bombero)bomberoResponsable).setEstrategiaDeApagado(null);
            ((Bombero)bomberoResponsable).setLugar(null);
            CuartelDeBombero.devolverAlICuartl(bomberoResponsable);

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Ejecuntado con Heroe Policia");
            Console.WriteLine("---------------------------------------------------------------");

            ICuartel Comisaria = crearHeroe(Policia);
            IResponsable PoliciaResponsable = Comisaria.getPersonal();
            PoliciaResponsable.patrullarCalles(new Calle("pergamono", 100, 4, 30));
            Comisaria.devolverAlICuartl(PoliciaResponsable);

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Ejecuntado con Heroe Medico");
            Console.WriteLine("---------------------------------------------------------------");

            ICuartel Hospital = crearHeroe(Medico);
            IResponsable MedicoResponsable = Hospital.getPersonal();
            MedicoResponsable.atenderInfartado(new Transeunte());
            Hospital.devolverAlICuartl(MedicoResponsable);

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Ejecuntado con Heroe Electricista");
            Console.WriteLine("---------------------------------------------------------------");

            //creo una manzana primera Manzana
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

            ICuartel CentralElectrica = crearHeroe(Electricista);
            IResponsable ElectricistaResponsable = CentralElectrica.getPersonal();
            ElectricistaResponsable.cambiarLamparasQuemadas(manzana1);
            CentralElectrica.devolverAlICuartl(ElectricistaResponsable);

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
    }
}
