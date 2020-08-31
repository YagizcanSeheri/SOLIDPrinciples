using SOLIDPrinciples.Dependency_Inversion_Principle.GoodExample.abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Dependency_Inversion_Principle.GoodExample.concrete
{
    public class Beef : IRecipe
    {
        public string CreateARecipe()
        {
            return "Medium well cooking beef";
        }
    }
}
