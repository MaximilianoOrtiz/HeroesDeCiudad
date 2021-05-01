using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Decorator.Decorados
{
    public class GenteAsustada : SectorDecorator
    {
        int cantDePersonas;

        public GenteAsustada(ISector sector, int cantDePersonas) : base(sector) {
            this.cantDePersonas = cantDePersonas;
        }
        public override void mojar(double agua) {
            base.mojar(agua - (agua * 0.75));
        }
        public override string ToString() {
            return base.ToString() + "   Gente asustada";
        }
    }
}
