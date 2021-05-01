using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Decorator.Decorados
{
    public class DiaVentoso : SectorDecorator
    {
        private double velocidadDelViento;

        public DiaVentoso(ISector sector, double velocidadDelViento) : base(sector) {
            this.velocidadDelViento = velocidadDelViento;
        }

        public override void mojar(double agua) {
                double cantDeAguaAhRestar = Math.Exp(velocidadDelViento / 100);
                base.mojar(agua - cantDeAguaAhRestar);
        }
        public override string ToString() {
            return base.ToString() + "   Dia ventoso";
        }
    }
}
