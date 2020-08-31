using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Liskov_Subtution_Principle.FalseExample
{
    public class FalseSquare:FalseRetangle
    {
        int _height;
        int _witdh;

        public override int Height
        {
            get { return _height; }
            set { _height = value; _witdh = value; }
        }

        public override int Width
        {
            get { return _witdh; }
            set { _height = value; _witdh = value; }
        }
    }
}
