using FiguresLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CircleTest_radius5_returned78()
        {
            //arrange
            double radius = 5.0;

            //act
            Circle circle = new Circle(radius);
            double act = circle.Square();

            //assert
            Assert.AreEqual(78.53981633974483, act);
        }
    }
}
