using Heroes.Itearator.IDenuncias;
using Heroes.Itearator.Iteradores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Itearator.Denuncias
{
    public class DenunciaPorMensajeWhatsApp : IDenuncias
    {
        public MensajeDeWhatsApp MensajeDeWhatsApp { get; set; }

        public DenunciaPorMensajeWhatsApp(MensajeDeWhatsApp mensajeDeWhatsApp ) {
            this.MensajeDeWhatsApp = mensajeDeWhatsApp;
        }

        public Iterator crearIterator() {
            return new IteradorDenunciaPorWhatsApp(MensajeDeWhatsApp);
        }
    }

   

    
}
