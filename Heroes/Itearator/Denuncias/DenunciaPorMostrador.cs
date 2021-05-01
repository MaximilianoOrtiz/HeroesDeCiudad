using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Itearator.Denuncias
{
    public class DenunciaPorMostrador : IDenuncias
    {
        public IDenuncia Denuncia { get; set; }

        public DenunciaPorMostrador(IDenuncia denuncia) {
            this.Denuncia = denuncia;
        }

        public Iterator crearIterator() {
            return new IteratorDenunciaPorMostrador(Denuncia);
        }
    }
}
