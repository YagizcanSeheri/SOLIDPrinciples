using SOLIDPrinciples.Interface_Segration_Principle.TrueExample.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Interface_Segration_Principle.TrueExample.Concrete
{
    public class Airplane : IFlyingVehicle,IGoOnLandVehicle
    {
        public string Fly()
        {
            throw new NotImplementedException();
        }

        public string GoOnLand()
        {
            throw new NotImplementedException();
        }
    }
}
