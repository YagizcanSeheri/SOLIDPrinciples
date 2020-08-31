using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.Liskov_Subtution_Principle.TrueExample
{
    public abstract class Shape
    {
        //Butun classlara verilicek ortak özellikler buraya yazılır.
        public virtual int Id { get; set; }
    }
}
