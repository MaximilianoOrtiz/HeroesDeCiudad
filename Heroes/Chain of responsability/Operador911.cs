using Heroes.Itearator;
using Heroes.Itearator.Denuncia;
using Heroes.Itearator.Denuncias;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Chain_of_responsability
{
    public class Operador911
    {
        public IResponsable CadenaDeResponsables;

        public Operador911(IResponsable Responsable) {
            this.CadenaDeResponsables = Responsable;
        }
        public void atenderDenuncias(IDenuncias denuncia) {

            Iterator denunciaCroncreta = denuncia.crearIterator();
            while (denunciaCroncreta.hastNext()) {

                IDenuncia denunciaActual = (IDenuncia)denunciaCroncreta.next();

                if (denunciaActual is DenunciaDeIncendio) {
                    imprimirTipoDeDenuncia("ATENDIENDO DENUNCIA DE INCENDIO");
                    denunciaActual.atender(CadenaDeResponsables);
                    Console.WriteLine("");
                    continue;
                }
                if (denunciaActual is DenunciaDeRobo) {
                    imprimirTipoDeDenuncia("ATENDIENDO DENUNCIA DE ROBO");
                    denunciaActual.atender(CadenaDeResponsables);
                    Console.WriteLine("");
                    continue;
                }
                if (denunciaActual is DenunciaDeLamparaQuemada) {
                    imprimirTipoDeDenuncia("ATENDIENDO DENUNCIA DE LAMPARA QUEMADA");
                    denunciaActual.atender(CadenaDeResponsables);
                    Console.WriteLine("");

                    continue;
                }
                if (denunciaActual is DenunciaDeInfarto) {
                    imprimirTipoDeDenuncia("ATENDIENDO DENUNCIA DE INFARTO");
                    denunciaActual.atender(CadenaDeResponsables);
                    Console.WriteLine("");
                    continue;
                }
            }
        }
       private  void imprimirTipoDeDenuncia(string denuncia) {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine(denuncia);
            Console.WriteLine("---------------------------------------------------------");

        }
    }
    
}
