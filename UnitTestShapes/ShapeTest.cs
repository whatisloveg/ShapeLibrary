using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;
using System;

namespace UnitTestShapes
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void CalculateTriangleArea()
        {
            //arrange
            IShape triange = new Triangle(7, 24, 25);
            double expected = 84;

            //act 

            double result = triange.CalculateArea();

            //assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void IsRightTriangle()
        {
            //arrange
            Triangle triange = new Triangle(7, 24, 25);
            bool expected = true;

            //act 

            bool result = triange.IsRightTriangle();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculteAreaCircle()
        {
            //arrange
            IShape circle = new Circle(2);
            double expected = 12.566370614359172;

            //act 

            double result = circle.CalculateArea();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestInCompileTime()
        {
            IShape[] shapes = {new Triangle(7, 24, 25), new Circle(2)};
            for (int i = 0; i < 2; i++)
            {
                shapes[i].CalculateArea();
            }
        }
    }
}
