using Heroes.Abstract_Factory;
using Heroes.Abstract_Factory.Herramientas;
using Heroes.Abstract_Factory.Vehiculos;
using Heroes.Itearator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Heroes
{
    class Medico : IResponsable
    {
        //campos
        private string nombre, apelllido;
        private Rcp protocoloRcp1, protocoloRcp2;

        public Rcp GetProtocoloRcp1() {
            return protocoloRcp1;
        }

        public void SetProtocoloRcp2(Rcp value) {
            protocoloRcp2 = value;
        }
        public Medico(IResponsable Sucesor, string nombre, string apellido) : base(Sucesor) {
            this.nombre = nombre;
            this.apelllido = apellido;
            this.protocoloRcp1 = new RcpEspañol();
            this.vehiculo = new Ambulancia();
            this.Herramienta = new Desfibrilador();
        }

        //propiedades
        public void SetProtocoloRcp(Rcp value) { protocoloRcp1 = value; }
        public Rcp GetProtocoloRcp() { return protocoloRcp2; }
        public void setNombre(string nombre) { this.nombre = nombre; }
        public string getNombre() { return nombre; }

        public void setApellido(string apellido) { this.apelllido = apellido; }
        public string getApellido() { return apelllido; }

        //metodos
        public override void atenderInfartado(IInfartable infartable) {
            if (vehiculo.conducir()) {
                this.Herramienta.usar();
                Console.WriteLine("");
                GetProtocoloRcp1().ejecutarProtocoloRcpPrimeraImplementacion(infartable);
                Console.WriteLine("");
                this.Herramienta.guardar();
            }
            else {
            Console.WriteLine("");
            Console.WriteLine("Lo lamento, no se ah podido llegar a destino");
            Console.WriteLine("");
            }
        }
       
    }
}
