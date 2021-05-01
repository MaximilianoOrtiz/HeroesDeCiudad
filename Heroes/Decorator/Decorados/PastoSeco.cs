using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Decorator
{
    public class PastoSeco : SectorDecorator
    {
        public PastoSeco(ISector sector) : base (sector){
        }
        public override void mojar(double agua) {
            base.mojar(agua/2);
        }
        public override string ToString() {
            return base.ToString() + "   Pasto seco";
        }
    }
}
