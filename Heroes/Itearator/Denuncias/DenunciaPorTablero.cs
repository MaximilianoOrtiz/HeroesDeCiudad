using Heroes.Heroes;
using Heroes.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Itearator.Denuncias
{
    public class DenunciaPorTablero : IObservador, IDenuncias
    {
        public List<IDenuncia> Denuncias { get; set; }

        public DenunciaPorTablero() {
            Denuncias = new List<IDenuncia>();
        }

        //implememnto la interface Iobservador
        public void actualizar(IObservado lugarObservado) {
            Denuncias.Add(new DenunciaDeIncendio(((Lugar)lugarObservado)));
        }
        //implementacion de la interface IDenuncias
        public Iterator crearIterator() {
            return new IteradorDenunciaPorTablero(Denuncias);
        }
    }
}
