using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class TriangleFactory : Factory
    {
        private readonly double _s;


        public TriangleFactory(double a, double b, double c) 
        {
            
            double p = (a + b + c) / 2; 
            _s = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); 
        }

        public override IFigure GetFigure()
        {
            Triangle triangle = new Triangle(_s)
            {
                s = _s
            };

            return triangle;
        }
    }
}
