using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void SquareTest_10and20and20_returned96()
        {
            //arrange
            double a = 10;
            double b = 20;
            double c = 20;

            //act
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.Square();

            //assert
            Assert.AreEqual(96.82458365518542, actual);
        }

        [TestMethod()]
        public void SquareTest_10and0and10_returnedExcpetion()
        {
            //arrange
            double a = 10;
            double b = 0;
            double c = 10;

            //act
            string actualStr = "";
            try
            {
                Triangle triangle = new Triangle(a, b, c);
                double actual = triangle.Square();
            }
            catch(Exception ex)
            {
                
                actualStr = ex.Message;
            }

            //assert
            Assert.AreEqual("Side b can't be <= 0", actualStr);
        }

        [TestMethod()]
        public void IsRectangularTest_5and4and3_returnedTrue()
        {
            //arrange
            int a = 5;
            int b = 4;
            int c = 3;

            //act
            Triangle triangle = new Triangle(a, b, c);
            bool isRectangular = triangle.IsRectangular();

            //assert
            Assert.AreEqual(true, isRectangular);
        }
    }
}