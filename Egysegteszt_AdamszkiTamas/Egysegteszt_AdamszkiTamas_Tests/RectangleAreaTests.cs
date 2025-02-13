using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Egysegteszt_AdamszkiTamas;

namespace Egysegteszt_AdamszkiTamas_Tests
{
    [TestClass]
    public class RectangleAreaTests
    {
        [TestMethod]
        public void CalculateArea_BothPositive_ReturnsResult()
        {
            var rectangle = new Rectangle();
            double width = 5;
            double height = 10;
            double expected = 50;

            double result = rectangle.CalculateArea(width, height);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateArea_WidthZero_ReturnsResult()
        {
            var rectangle = new Rectangle();
            double width = 0;
            double height = 10;
            double expected = 0;

            double result = rectangle.CalculateArea(width, height);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateArea_HeightZero_ReturnsResult()
        {
            var rectangle = new Rectangle();
            double width = 10;
            double height = 0;
            double expected = 0;

            double result = rectangle.CalculateArea(width, height);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CalculateArea_WidthNegative_ReturnsResult()
        {
            var rectangle = new Rectangle();
            double width = -5;
            double height = 10;

            double result = rectangle.CalculateArea(width, height);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CalculateArea_HeightNegative_ReturnsResult()
        {
            var rectangle = new Rectangle();
            double width = 10;
            double height = -5;

            double result = rectangle.CalculateArea(width, height);
        }

        [TestMethod]
        public void CalculateArea_LongSides_ReturnsResult()
        {
            var rectangle = new Rectangle();
            double width = 1000000;
            double height = 2000000;
            double expected = 2000000000000;

            double result = rectangle.CalculateArea(width, height);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateArea_NotIntegerSides_ReturnsResult()
        {
            var rectangle = new Rectangle();
            double width = 4.5;
            double height = 8.2;
            double expected = 36.9;

            double result = rectangle.CalculateArea(width, height);

            Assert.AreEqual(expected, result);
        }
    }
}
