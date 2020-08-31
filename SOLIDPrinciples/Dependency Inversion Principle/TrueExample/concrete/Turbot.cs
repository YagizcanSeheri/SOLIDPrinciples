using SOLIDPrinciples.Dependency_Inversion_Principle.GoodExample.abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Dependency_Inversion_Principle.GoodExample.concrete
{
    public class Turbot : IRecipe
    {
        public string CreateARecipe()
        {
           return "Grilled Turbot";
        }
    }
}
