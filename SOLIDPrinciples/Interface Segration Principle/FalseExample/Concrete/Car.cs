using SOLIDPrinciples.Interface_Segration_Principle.FalseExample.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Interface_Segration_Principle.FalseExample.Concrete
{
    public class Car : IVehicle
    {
        public string Fly()
        {
            return "Arabalar Uçamaz..!!";
        }

        public string GoOnLand()
        {
            return "Arabalar Karada gidebilir.";
        }
    }
}
