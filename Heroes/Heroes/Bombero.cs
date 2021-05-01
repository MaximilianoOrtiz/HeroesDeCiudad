using Heroes.Abstract_Factory.Herramientas;
using Heroes.Abstract_Factory.Vehiculos;
using Heroes.Heroes;
using Heroes.Itearator;
using Heroes.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Bombero : IResponsable, IObservador
    {
        //campos
        private string nombre;
        private int dni;
        private Lugar lugar;
        private IStrategyDeApagadoDeIncendio estrategiaDeApagado;
        private string apellido;

        //Constructores
        public Bombero(IResponsable Sucesor, IStrategyDeApagadoDeIncendio strategyDeApagadoDeIncendio) : base(Sucesor) {
            this.estrategiaDeApagado = strategyDeApagadoDeIncendio;
            this.Herramienta = new Manguera();
            this.vehiculo = new Autobomba();
        }

        public Bombero(IResponsable Sucesor) : base(Sucesor) {
            this.Herramienta = new Manguera();
            this.vehiculo = new Autobomba();
        }

        public Bombero(IResponsable Sucesor, Lugar lugar, IStrategyDeApagadoDeIncendio estrategiaDeApagado) : base(Sucesor) {
            this.lugar = lugar;
            this.estrategiaDeApagado = estrategiaDeApagado;
            this.Herramienta = new Manguera();
            this.vehiculo = new Autobomba();
        }

        //propiedades
        public void SetNombre(string value) { nombre = value; }
        public string getNombre() { return nombre; }

        public int GetDni() { return dni; }
        public void SetDni(int value) { dni = value; }

        public string GetApellido() { return apellido; }
        public void SetApellido(string value) { apellido = value; }

        public IStrategyDeApagadoDeIncendio getEstrategiaDeApagado() { return estrategiaDeApagado; }
        public void setEstrategiaDeApagado(IStrategyDeApagadoDeIncendio value) { estrategiaDeApagado = value; }

        public Lugar getLugar() { return lugar; }
        public void setLugar(Lugar value) { lugar = value; }

        //metodos

        public void apagarIncendio() {
            if (vehiculo.conducir()) {
                this.Herramienta.usar();             
                Console.WriteLine("");
                estrategiaDeApagado.apagarIncendio(this.lugar, this.lugar.getCalle());
                Console.WriteLine("");
                this.Herramienta.guardar();
            }
            else {
                Console.WriteLine("");
                Console.WriteLine("Lo lamento, no se ah podido llegar a destino");
                Console.WriteLine("");

            }
        }

        //utilizado en el metodo atender de la denuncia de incendio
        public override void apagarIncendio(Lugar lugar) {
            if (vehiculo.conducir()) {
                this.Herramienta.usar();
                this.lugar = lugar;
                Console.WriteLine("");
                estrategiaDeApagado.apagarIncendio(lugar, lugar.getCalle());
                Console.WriteLine("");
                this.Herramienta.guardar();
            }
            else {
            Console.WriteLine("");
            Console.WriteLine("Lo lamento, no se ah podido llegar a destino");
                Console.WriteLine("");
            }
        }

        public void bajarGatitoDelArbol() {
            Console.WriteLine("bajando gatito del arbol");
        }

        //Implementacion de la interface IObservador
        public void actualizar(IObservado lugarObservado) {
            if (lugarObservado is Casa) {
                lugar = (Lugar)lugarObservado;
                setEstrategiaDeApagado(new Secuencial());
                apagarIncendio();
            }
            if (lugarObservado is Plaza) {
                lugar = (Lugar)lugarObservado;
                estrategiaDeApagado = new Escalera();
                apagarIncendio();
            }
        }
    }
}
