using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Dependency_Inversion_Principle.BadExample
{
    public class FalseFish
    {
        public string GetFishCookingRecipe()
        {
            return "Grilled Turbot";
        }
    }
}
