using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Liskov_Subtution_Principle.FalseExample
{
    public class FalseRetangle
    {
        //bu class base class
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }
}
