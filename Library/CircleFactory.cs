using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CircleFactory : Factory
    {
        private readonly double _s;


        public CircleFactory(double r) 
        {
            _s = Math.PI * r * r; 
        }

        public override IFigure GetFigure()
        {
            Circle circle = new Circle(_s)
            {
                s = _s
            };

            return circle;
        }
    }
}
