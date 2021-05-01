using Heroes.Decorator;
using Heroes.Decorator.Decorados;
using Heroes.Factory_Method;
using Heroes.Heroes;
using Heroes.Observer;
using System;
using System.Collections.Generic;

namespace Heroes
{
    public abstract class Lugar : IObservado
    {
        //Campos
        protected Calle calle;
        private List<IObservador> bomberosObservadores = new List<IObservador>();

        //Propiedad
        public List<IObservador> getBommberosObservadores() { return bomberosObservadores; }
        public void setBommberosObservadores(List<IObservador> value) { bomberosObservadores = value; }

        public Calle getCalle() { return calle; }
        public void setCalle(Calle calle) { this.calle = calle; }

        //Implementacion de la Interface IObservado
        public void agregarObservador(IObservador observador) {
            bomberosObservadores.Add(observador);
        }

        public void quitarIObservador(IObservador observador) {
            bomberosObservadores.Remove(observador);
        }

        public void notificar() {
            foreach (IObservador observador in bomberosObservadores) {
                observador.actualizar(this);
            }
        }

        public abstract ISector[,] getSectores();

        //decora un sector al azar
        //public static ISectorComponete decorarSector(ISectorComponete sector) {

        //    Random probabilidad = new Random();

        //    double probabilidadDeDecorar = 0.1;
        //    if (probabilidad.NextDouble() < probabilidadDeDecorar)
        //        sector = FabricaDeDecorados.crearDecorado(FabricaDeDecorados.pastoSeco, sector);   // new PastoSeco(sector);
        //    if (probabilidad.NextDouble() < probabilidadDeDecorar)
        //        sector = FabricaDeDecorados.crearDecorado(FabricaDeDecorados.arbolGrande, sector); //new ArbolGrande(sector);
        //    if (probabilidad.NextDouble() < probabilidadDeDecorar)
        //        sector = FabricaDeDecorados.crearDecorado(FabricaDeDecorados.genteAsustada, sector);  //new GenteAsustada(sector, probabilidad.Next(1, 6));
        //    if (probabilidad.NextDouble() < probabilidadDeDecorar)
        //        sector = FabricaDeDecorados.crearDecorado(FabricaDeDecorados.diaDeMuchoCalor, sector);  // new DiaDeMuchoCalor(sector, temperatura);
        //    if (probabilidad.NextDouble() < probabilidadDeDecorar)
        //        sector = FabricaDeDecorados.crearDecorado(FabricaDeDecorados.diaVentoso, sector);  // new DiaVentoso(sector, velocidadDelViento);
        //    if (probabilidad.NextDouble() < probabilidadDeDecorar)
        //        sector = FabricaDeDecorados.crearDecorado(FabricaDeDecorados.diaLluvioso, sector);   //new DiaLluvioso(sector, intensidadDeLaLluvia);

        //    return sector;
        //}

        public void chispa() {
            notificar();
        }
    }
}