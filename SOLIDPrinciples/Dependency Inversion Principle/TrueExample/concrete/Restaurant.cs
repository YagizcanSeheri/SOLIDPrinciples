using SOLIDPrinciples.Dependency_Inversion_Principle.GoodExample.abstraction;
using System.Collections.Generic;


namespace SOLIDPrinciples.Dependency_Inversion_Principle.GoodExample.concrete
{
    public class Restaurant
    {
        List<IRecipe> recipes;
        public Restaurant()
        {
            recipes = new List<IRecipe>();
        }
        public string GenerateRecipe()
        {
            string recipe = string.Empty;

            foreach (var item in recipes)
            {
                recipe += " " + item.CreateARecipe();
            }

            return recipe;

        }

    }
}
