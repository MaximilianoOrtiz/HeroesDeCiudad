using Heroes.State.Estados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Abstract_Factory.Vehiculos
{ 
    public interface IVehiculo 
    {
        void encenderSirena();

        //void  conducir();

        bool conducir();
    }
}
