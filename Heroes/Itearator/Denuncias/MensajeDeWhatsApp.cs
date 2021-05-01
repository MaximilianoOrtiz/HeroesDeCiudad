using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Itearator.IDenuncias
{
    public class MensajeDeWhatsApp
    {
        public IDenuncia Denuncia { get; set; }

        public MensajeDeWhatsApp Siguiente { get; set; }

        public MensajeDeWhatsApp(IDenuncia denuncia, MensajeDeWhatsApp siguiente) {
            this.Denuncia = denuncia;
            this.Siguiente = siguiente;
        }
    }
}
