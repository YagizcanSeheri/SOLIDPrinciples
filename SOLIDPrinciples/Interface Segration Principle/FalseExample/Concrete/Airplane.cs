using SOLIDPrinciples.Interface_Segration_Principle.FalseExample.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Interface_Segration_Principle.FalseExample.Concrete
{
    public class Airplane : IVehicle
    {
        public string Fly()
        {
            return "Uçaklar Uçabilir.";
        }

        public string GoOnLand()
        {
            return "Uçaklar Karada Gidebilir";
        }
    }
}
