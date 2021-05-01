using Heroes.Itearator;
using Heroes.Itearator.Denuncias;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Heroes
{
    public class BomberoSecretario
    {
        public Bombero bomberoSecretario { get;set; }

        public BomberoSecretario(Bombero bomberoSecretario) {
            this.bomberoSecretario = bomberoSecretario;
        }

        public void atenderDenuncias(IDenuncias denuncia) {

            Iterator iteradorConcreto = denuncia.crearIterator();
            while (iteradorConcreto.hastNext()) {
                DenunciaDeIncendio denunciaDeIncendio = (DenunciaDeIncendio)iteradorConcreto.next();
                denunciaDeIncendio.atender(bomberoSecretario);
            }

        }
    }
}
