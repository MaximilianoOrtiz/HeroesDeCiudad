using Heroes.Heroes;
using Heroes.Template_Method;
using HeroesDeCiudad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Adapter
{
    public class AdapterMain
    {
        public static void rum() {

            Console.WriteLine("Creando transeunte Extrangero y medico.....   Creado");
            Medico medico = new Medico(null,"maxi", "ortiz");

            Passerby passerby = new Passerby(0.2, 0.5, 0.8);
            TranseunteAdapter transeunteExtrangero = new TranseunteAdapter(passerby);

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Selecione el idioma en que se ejecuta el rcp:");
            Console.WriteLine("1)Español");
            Console.WriteLine("2)Ingles");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion) {
                case 1: { medico.SetProtocoloRcp(new RcpEspañol()); break; }
                case 2: { medico.SetProtocoloRcp(new RcpIngles()); break; }
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ejecutando protocolo de RCP");
            Console.WriteLine("");

            medico.atenderInfartado(transeunteExtrangero);

        }
    }
}


