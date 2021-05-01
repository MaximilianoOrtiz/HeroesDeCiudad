using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Decorator
{
    public abstract class SectorDecorator : ISector
    {
        protected ISector sector;

        public SectorDecorator(ISector sector) {
            this.sector = sector;
        }
        virtual public bool estaApagado() {
            return sector.estaApagado();
        }
        virtual public void mojar(double agua) {
            sector.mojar(agua);
        }
        public override string ToString() {
            return sector.ToString();
        }
    }
}
