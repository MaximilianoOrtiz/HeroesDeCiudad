using Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Composite
{
    public class compositeMain
    {

        public static void run() {

            Electricista electricista = new Electricista(null,"maxi", "ortiz", 38950523);
            lugarCompuesto barrio = crearBarrio();
            electricista.cambiarLamparasQuemadas(barrio);
        }

        public static lugarCompuesto crearBarrio() {

            Director director = new Director(new BuilderSimple());

            //creao la primera Manzana
            Esquina esquina1 = new Esquina("Oncativo y Pedriel", 12);
            Esquina esquina2 = new Esquina("Brochero y Pedriel", 4);
            Esquina esquina3 = new Esquina("Oncativo y Pinochado", 5);
            Esquina esquina4 = new Esquina("O y Pedriel", 12);

            Calle calle1 = new Calle("Pergamino", 100, 4, 50);
            Calle calle2 = new Calle("Brochero", 100, 7, 50);
            Calle calle3 = new Calle("Pedriel", 100, 6, 50);
            Calle calle4 = new Calle("Oncativo", 100, 8, 50);

            Plaza plaza = new Plaza(director, "Americas", 10, 40, calle1);

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

            //creao la segunda Manzana
            Esquina esquinaM1 = new Esquina("58 y 65", 12);
            Esquina esquinaM2 = new Esquina("45 y 14", 4);
            Esquina esquinaM3 = new Esquina("25 y 36", 5);
            Esquina esquinaM4 = new Esquina("23 y 24", 12);

            Calle calleM1 = new Calle("58", 100, 5, 50);
            Calle calleM2 = new Calle("45", 100, 7, 50);
            Calle calleM3 = new Calle("36", 100, 4, 50);
            Calle calleM4 = new Calle("14", 100, 6, 50);

            Plaza plazaM = new Plaza(director, "Bosques", 10, 40, calleM1);

            lugarCompuesto manzana2 = new lugarCompuesto();


            manzana2.agregarLugar(esquinaM1);
            manzana2.agregarLugar(esquinaM2);
            manzana2.agregarLugar(esquinaM3);
            manzana2.agregarLugar(esquinaM4);

            manzana2.agregarLugar(calleM1);
            manzana2.agregarLugar(calleM2);
            manzana2.agregarLugar(calleM3);
            manzana2.agregarLugar(calleM4);

            manzana2.agregarLugar(plazaM);


            //CREO BARRIO CON 2 MANZANA

            lugarCompuesto barrio = new lugarCompuesto();

            barrio.agregarLugar(manzana1);
            barrio.agregarLugar(manzana2);

            return barrio;
        }


    }
}
