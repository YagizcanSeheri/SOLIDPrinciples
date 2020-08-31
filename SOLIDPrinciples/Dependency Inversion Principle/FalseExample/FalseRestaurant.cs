using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Dependency_Inversion_Principle.BadExample
{
    public class FalseRestaurant
    {
        FalseBeef beef = new FalseBeef();
        FalseFish turbot = new FalseFish();
        public string CreateARecipe()
        {
            return beef.GetBeefCookingRecipe() + " " + turbot.GetFishCookingRecipe();
        }
    }
}
