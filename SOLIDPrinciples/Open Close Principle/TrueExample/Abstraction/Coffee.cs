using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Open_Close_Principle.TrueExample.Abstraction
{
    public abstract class Coffee
    {
        public abstract double GetTotalPrice(double amount);
    }
}
