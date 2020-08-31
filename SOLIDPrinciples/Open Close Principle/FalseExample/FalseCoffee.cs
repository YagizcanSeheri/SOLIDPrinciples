using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Open_Close_Principle.FalseExample
{
    public enum CoffeeType
    {
        Latte,
        Mocha,
        TurkishCoffe
    }

    public class FalseCoffee
    {
        public double GetTotalPrice(double amount, CoffeeType coffeeType)
        {
            double totalPrice = 0;

            if (coffeeType == CoffeeType.Latte)
            {
                totalPrice += amount * 4.50;
            }
            else if (coffeeType == CoffeeType.Mocha)
            {
                totalPrice += amount * 5.25;
            }
            else if (coffeeType == CoffeeType.TurkishCoffe)
            {
                totalPrice += amount * 6.75;
            }

            return totalPrice;
        }
    }
}
