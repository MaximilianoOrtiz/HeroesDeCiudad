using Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Template_Method
{
    public class TemplateMethodMain
    {
        public static void rum() {
            Console.WriteLine("Creando transeunte y medico.....   Creado");
            Medico medico = new Medico(null,"maxi", "ortiz");
            Transeunte transeunte = new Transeunte();
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

            medico.atenderInfartado(transeunte);

        }
    }
}
