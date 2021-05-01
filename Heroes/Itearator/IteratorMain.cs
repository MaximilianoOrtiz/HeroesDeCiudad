using Heroes.Heroes;
using Heroes.Itearator.IDenuncias;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Itearator.Denuncias
{
    class IteratorMain
    {
        public static void run() {

            //Tesing
            
            Console.WriteLine("Creando escenario del testing....");
            Console.WriteLine("");

            Bombero bombero = new Bombero(null,new Secuencial());
            BomberoSecretario bomberoSecretario = new BomberoSecretario(bombero);

            Director director = new Director(new BuilderSimple());

            Calle calle1 = new Calle("Pergamino", 100, 4, 50);
            Calle calle2 = new Calle("Brochero", 100, 7, 50);
            Calle calle3 = new Calle("Pedriel", 100, 6, 50);
            Calle calle4 = new Calle("Oncativo", 100, 8, 50);

            Lugar A = new Plaza(director, "Americas", 10, 40, calle1);
            Lugar B = new Casa(director, 4, 20, 40, calle2);
            Lugar C = new Plaza(director, "Americas Argentinas", 10, 40, calle2);
            Lugar D = new Plaza(director, "Amer Argentinas", 10, 40, calle3);
            Lugar E = new Casa(director,4, 45, 40, calle2);
            Lugar F = new Plaza(director, "Lujan ", 10, 60, calle1);
            Lugar G = new Plaza(director, "Hudson ", 10, 50, calle2);
            Lugar H = new Plaza(director, "Rotonda", 10, 90, calle3);
            Lugar I = new Casa(director, 4, 30, 5, calle2);
            Lugar J = new Casa(director, 4, 33, 7, calle1);


            Console.WriteLine("Se a creado un bombero Secretario y 10 lugares (Plaza / Casa)");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("");

            IDenuncias denunciaPorTablero = new DenunciaPorTablero();
            A.agregarObservador((DenunciaPorTablero)denunciaPorTablero);
            B.agregarObservador((DenunciaPorTablero)denunciaPorTablero);
            C.agregarObservador((DenunciaPorTablero)denunciaPorTablero);
            D.agregarObservador((DenunciaPorTablero)denunciaPorTablero);
            E.agregarObservador((DenunciaPorTablero)denunciaPorTablero);
            F.agregarObservador((DenunciaPorTablero)denunciaPorTablero);

            MensajeDeWhatsApp lista = null;
            lista = new MensajeDeWhatsApp(new DenunciaDeIncendio(G), lista);
            lista = new MensajeDeWhatsApp(new DenunciaDeIncendio(H), lista);
            lista = new MensajeDeWhatsApp(new DenunciaDeIncendio(I), lista);
            IDenuncias denunciaPorMensajeWhatsApp = new DenunciaPorMensajeWhatsApp(lista);



            IDenuncias denunciaPorMostrador = new DenunciaPorMostrador(new DenunciaDeIncendio(J));

            Console.WriteLine("Testing Denuncias Por Tablero...");
            Console.WriteLine("");

            B.chispa();
            F.chispa();
            bomberoSecretario.atenderDenuncias(denunciaPorTablero);

            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Testing Denuncias Por WhatsApp...");
            Console.WriteLine("");

            bomberoSecretario.atenderDenuncias(denunciaPorMensajeWhatsApp);

            Console.WriteLine("");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Testing Denuncias Por Mostrador.");
            Console.WriteLine("");

            bomberoSecretario.atenderDenuncias(denunciaPorMostrador);

            Console.WriteLine("");
            Console.WriteLine("Se ah ejecutado el Testing exitosamente. Presione una tecla ");
            Console.ReadLine();
        }
    }
}
