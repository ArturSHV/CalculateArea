using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Class1
    {
        
        public static double Calculate(this double s,string type)
        {
            Factory factory = GetFigure(type);

            IFigure figure = factory.GetFigure();

            return figure.s;
        }


        private static Factory GetFigure(string type)
        {
            switch (type)
            {
                case "1":
                    Console.WriteLine("Введите длины сторон треугольника");
                    var a = Convert.ToInt32(Console.ReadLine());
                    var b = Convert.ToInt32(Console.ReadLine());
                    var c = Convert.ToInt32(Console.ReadLine());
                    return new TriangleFactory(a,b,c);

                case "2":
                    Console.WriteLine("Введите радиус");
                    var r = Convert.ToInt32(Console.ReadLine());
                    return new CircleFactory(r);

                default:
                    return null;
            };
        }


    }
}
