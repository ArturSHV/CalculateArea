using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Triangle : IFigure
    {
        public double s { get; set; }

        public Triangle() { }
        public Triangle(double s)
        {
            this.s = s;
        }

        double IFigure.GetArea()
        {
            return s;
        }
    }
}
