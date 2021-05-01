﻿using Heroes.Abstract_Factory.Cuarteles;
using Heroes.Abstract_Factory.FabricaDeHeroes;
using Heroes.Abstract_Factory.Herramientas;
using Heroes.Abstract_Factory.Vehiculos;
using Heroes.Adapter;
using Heroes.Chain_of_responsability;
using Heroes.Heroes;
using Heroes.Itearator;
using Heroes.Itearator.Denuncia;
using Heroes.Itearator.Denuncias;
using Heroes.Itearator.IDenuncias;
using Heroes.Template_Method;
using HeroesDeCiudad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Proxy
{
    public class ProxyMain
    {
        public static void run() {

            IFabricaDeHeroes bombero = new HeroeBombero();
            IFabricaDeHeroes Policia = new HeroePolicia();
            IFabricaDeHeroes Medico = new HeroeMedico();
            IFabricaDeHeroes Electricista = new HeroeElectricista();

            //Creo 4 cuarteles y le cargo 4 heroes , 4 herramientas y 4 vehiculos

            ICuartel cuartelDeBomberos = crearHeroe(bombero);
            cuartelDeBomberos = crearHeroe(bombero);
            cuartelDeBomberos = crearHeroe(bombero);
            cuartelDeBomberos = crearHeroe(bombero);
            cuartelDeBomberos = crearHeroe(bombero);

            ICuartel Comisaria = crearHeroe(Policia);
            Comisaria = crearHeroe(Policia);
            Comisaria = crearHeroe(Policia);
            Comisaria = crearHeroe(Policia);
            Comisaria = crearHeroe(Policia);

            ICuartel Hospital = crearHeroe(Medico);
            Hospital = crearHeroe(Medico);
            Hospital = crearHeroe(Medico);
            Hospital = crearHeroe(Medico);
            Hospital = crearHeroe(Medico);

            ICuartel CentralElectrica = crearHeroe(Electricista);
            CentralElectrica = crearHeroe(Electricista);
            CentralElectrica = crearHeroe(Electricista);
            CentralElectrica = crearHeroe(Electricista);
            CentralElectrica = crearHeroe(Electricista);


            IResponsable cadenaDeResponsables = new MedicoProxy(null);
            cadenaDeResponsables = new BomberoProxy(cadenaDeResponsables);
            cadenaDeResponsables = new ElectricistaProxy(cadenaDeResponsables);
            cadenaDeResponsables = new PoliciaProxy(cadenaDeResponsables);

            Operador911 operador911 = new Operador911(cadenaDeResponsables);

            //Bombero bombero = new Bombero(null, new Secuencial());
            //BomberoSecretario bomberoSecretario = new BomberoSecretario(bombero);

            Director director = new Director(new BuilderSimple());

            Calle calle1 = new Calle("Pergamino", 100, 4, 50);
            Calle calle2 = new Calle("Brochero", 100, 7, 50);
            Calle calle3 = new Calle("Pedriel", 100, 6, 50);
            Calle calle4 = new Calle("Oncativo", 100, 8, 50);
            Lugar G = new Plaza(director, "Hudson ", 10, 50, calle2);
            Lugar H = new Plaza(director, "Rotonda", 10, 90, calle3);
            Lugar I = new Casa(director, 4, 30, 5, calle2);

            MensajeDeWhatsApp lista = null;
            lista = new MensajeDeWhatsApp(new DenunciaDeIncendio(G), lista);
            lista = new MensajeDeWhatsApp(new DenunciaDeIncendio(H), lista);
            lista = new MensajeDeWhatsApp(new DenunciaDeIncendio(I), lista);
            lista = new MensajeDeWhatsApp(new DenunciaDeInfarto(new Transeunte()), lista);
            lista = new MensajeDeWhatsApp(new DenunciaDeInfarto(new TranseunteAdapter(new Passerby(30, 40, 80))), lista);
            lista = new MensajeDeWhatsApp(new DenunciaDeRobo(calle1), lista);
            lista = new MensajeDeWhatsApp(new DenunciaDeRobo(calle2), lista);
            lista = new MensajeDeWhatsApp(new DenunciaDeRobo(calle3), lista);
            lista = new MensajeDeWhatsApp(new DenunciaDeLamparaQuemada(calle3), lista);

            IDenuncias denunciaPorMensajeWhatsApp = new DenunciaPorMensajeWhatsApp(lista);

            operador911.atenderDenuncias(denunciaPorMensajeWhatsApp);
        }
        public static ICuartel crearHeroe(IFabricaDeHeroes fabricaDeHeroes) {

            ICuartel cuartel = fabricaDeHeroes.crearCuartel();
            IResponsable responsable = fabricaDeHeroes.crearHeroe();
            IVehiculo vehiculo = fabricaDeHeroes.crearVehiculo();
            IHerramienta herramienta = fabricaDeHeroes.crearHerramienta();

            cuartel.agregarVehiculo(vehiculo);
            cuartel.agregarPersonal(responsable);
            cuartel.agregarHerramienta(herramienta);
            return cuartel;
        }

    }
}
