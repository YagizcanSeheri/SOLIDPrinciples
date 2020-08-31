using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Liskov_Subtution_Principle.TrueExample.Concrete
{
    public class Retangle:Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public double RetangleArea()
        {
            return Width * Height;
        }
    }
}
