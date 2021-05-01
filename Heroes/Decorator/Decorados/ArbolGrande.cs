using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Decorator
{
    public class ArbolGrande : SectorDecorator
    {
        public ArbolGrande(ISector sector) : base(sector) {
        }
        public override void mojar(double agua) {

            double veinticincoPorcientoDelAgua = agua * 0.25;
            base.mojar(agua - veinticincoPorcientoDelAgua);
        }
        public override string ToString() {
            return base.ToString() + "   Arboles Generales";
        }
    }
}
