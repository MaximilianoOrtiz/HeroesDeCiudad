using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Decorator.Decorados
{
    public class DiaLluvioso : SectorDecorator {
        private double intencidadDeLluvia;
        public DiaLluvioso(ISector sector, double intenciadadDeLluvia) : base(sector) {
            this.intencidadDeLluvia = intenciadadDeLluvia;
        }

        public override void mojar(double agua) {
                base.mojar(agua + intencidadDeLluvia);
        }
        public override string ToString() {
            return base.ToString() + "   Dia lluvioso";
        }
    }
}