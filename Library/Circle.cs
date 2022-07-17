using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Circle : IFigure
    {
        public double s { get; set; }

        public Circle() { }
        public Circle(double s)
        {
            this.s = s;
        }

        double IFigure.GetArea()
        {
            return s;
        }
    }
}
