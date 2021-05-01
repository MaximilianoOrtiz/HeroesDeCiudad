using Heroes.Itearator.IDenuncias;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Itearator.Iteradores
{
    public class IteradorDenunciaPorWhatsApp : Iterator
    {
        MensajeDeWhatsApp mensajeDeWhatsApp;
        //int pocicionActual;
        //int cantidadDeMensajes;
        bool ultimaVez = true;
        public IteradorDenunciaPorWhatsApp(MensajeDeWhatsApp mensajeDeWhatsApp) {
            this.mensajeDeWhatsApp = mensajeDeWhatsApp;
            //pocicionActual = 0;
            //cantidadDeMensajes = contarMensajes(mensajeDeWhatsApp);
        }

        //devuelve la cantidad de msj que tengo de forma recursiva
        //private int contarMensajes(MensajeDeWhatsApp mensajeDeWhatsApp) {
        //    int cantidad = 1;
        //    if (mensajeDeWhatsApp.Siguiente == null)
        //        return 1;
        //    else {
        //        return cantidad += contarMensajes(mensajeDeWhatsApp.Siguiente);
        //    }
        //}

        //implementa la interface Iterator
        public bool hastNext() {
           // return (pocicionActual < cantidadDeMensajes);
            bool aux = ultimaVez;
            if (mensajeDeWhatsApp != null) { 
                aux = mensajeDeWhatsApp.Siguiente != null || ultimaVez;
                ultimaVez = mensajeDeWhatsApp.Siguiente == null ? false : true;   
            }
            return (aux);
        }

        public object next() {
            MensajeDeWhatsApp mensajeDeWhatsAppActual = mensajeDeWhatsApp;
            mensajeDeWhatsApp = mensajeDeWhatsApp.Siguiente;
           // pocicionActual++;
            return mensajeDeWhatsAppActual.Denuncia;
        }
    }
}
