using Heroes.Abstract_Factory.Herramientas;
using Heroes.Abstract_Factory.Vehiculos;
using Heroes.Command;
using Heroes.Composite;
using Heroes.Heroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Itearator
{
    public abstract class IResponsable
    {
        //campos
        protected IHerramienta Herramienta;
        protected IVehiculo vehiculo;

        public IResponsable Sucesor { get; set; } 

        //constructor
        public IResponsable(IResponsable Sucesor) {
            this.Sucesor = Sucesor;
        }

        //propiedades
        public IHerramienta getHerramienta() { return this.Herramienta; }
        public void setHerramienta(IHerramienta herramienta) { this.Herramienta = herramienta; }
        public IVehiculo getVehiculo() { return this.vehiculo; }
        public void setVehiculo(IVehiculo vehiculo) { this.vehiculo = vehiculo; }


        //metodos
        public virtual void apagarIncendio(Lugar lugar) {             
            if (Sucesor != null)
                Sucesor.apagarIncendio(lugar);
        }
        public virtual void atenderInfartado(IInfartable infartable) {
            if (Sucesor != null)
                Sucesor.atenderInfartado(infartable);
        }

        public virtual void cambiarLamparasQuemadas(IIluminable lugarIluminable) {
            if (Sucesor != null)
                Sucesor.cambiarLamparasQuemadas(lugarIluminable);
        }
        public virtual void patrullarCalles(IPatrullable patrullable) {
            if (Sucesor != null)
                Sucesor.patrullarCalles(patrullable);
        }

        
    }
}
