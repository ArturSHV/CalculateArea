using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Library;

namespace LibraryTest
{
    [TestClass]
    public class TraingleFactoryTest
    {
        [TestMethod]
        public void AreaTriangle()
        {
            double a = 10;
            double b = 10;
            double c = 10;
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            TriangleFactory triangleFactory = new TriangleFactory(a, b, c);
            double actual = triangleFactory.GetFigure().s;


            Assert.AreEqual(s, actual);
        }
    }
}
