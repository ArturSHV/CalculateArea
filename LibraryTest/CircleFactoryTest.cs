using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Library;

namespace LibraryTest
{
    [TestClass]
    public class CircleFactoryTest
    {
        [TestMethod]
        public void AreaCircle()
        {
            double r = 10;
            double s = Math.PI * r * r;

            CircleFactory circleFactory = new CircleFactory(r);
            double actual = circleFactory.GetFigure().s;


            Assert.AreEqual(s, actual);
        }

        
    }
}
