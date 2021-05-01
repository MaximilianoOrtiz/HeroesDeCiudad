
using Heroes.Abstract_Factory.Herramientas;
using Heroes.Abstract_Factory.Vehiculos;
using Heroes.Composite;
using Heroes.Itearator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Heroes
{
    public class Electricista : IResponsable
    {
        //Campos
        private string nombre, apellido;
        private int dni;

        //Constructor
        public Electricista(IResponsable responsable) : base(responsable) {
            this.vehiculo = new Camioneta();
            this.Herramienta = new Buscapolo();

        }
        public Electricista(IResponsable responsable, string nombre, string apellido, int dni) : base(responsable) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.vehiculo = new Camioneta();
            this.Herramienta = new Buscapolo();
        }

        //propiedades
        public void setNombre(string nombre) { this.nombre = nombre; }
        public string getNombre() { return this.nombre; }
        public void setApellido(string apellido) { this.apellido = apellido; }
        public string getApellido() { return this.apellido; }
        public void setDni(int dni) { this.dni = dni; }
        public int getDni() { return this.dni; }

        public override string ToString() {
            return nombre + " " + apellido;
        }

        //Metodos

        public override void cambiarLamparasQuemadas(IIluminable lugarIluminable) {
            if (vehiculo.conducir()) {
                this.Herramienta.usar();
                Console.WriteLine("");
                lugarIluminable.revisarYCambiarLamparasQuemadas();
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