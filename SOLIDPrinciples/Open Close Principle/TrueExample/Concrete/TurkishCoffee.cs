using SOLIDPrinciples.Open_Close_Principle.TrueExample.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Open_Close_Principle.TrueExample.Concrete
{
    public class TurkishCoffee:Coffee
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 6.75;
        }
    }
}
