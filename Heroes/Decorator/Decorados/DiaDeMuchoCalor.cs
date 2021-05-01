using Heroes.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class DiaDeMuchoCalor : SectorDecorator
    {
        private double temperatura;
        public DiaDeMuchoCalor(ISector sector, double temperatura) : base(sector) {
            this.temperatura = temperatura;
        }

        public override void mojar(double agua) {
            base.mojar(agua - (0.1 * temperatura));
        }
        public override string ToString() {
            return base.ToString() + "   Dia Caluroso";
        }
    }
}
