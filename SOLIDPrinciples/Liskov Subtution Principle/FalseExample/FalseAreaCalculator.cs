using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Liskov_Subtution_Principle.FalseExample
{
    public class FalseAreaCalculator
    {
        public static double CalculateArea(FalseRetangle retangle)
        {
            return retangle.Height * retangle.Width;
        }

        public static double CalculateArea(FalseSquare square)
        {
            return square.Width * square.Height;
        }
    }
}
