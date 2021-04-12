using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes_Lib;
using System;

namespace ShapesLib_Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void CreateRoundTest()
        {
            // arange
            double arg1 = 5; //radius
            Round expected = new Round(5);
            // act
            var result = ShapesLib.CreateShape(arg1);
            // assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void CreateTriangleTest()
        {
            // arrange
            double arg1 = 12; //a
            double arg2 = 15; //b
            double arg3 = 18; //c
            Triangle expected = new Triangle(12,15,18);
            // act
            var result = ShapesLib.CreateShape(arg1,arg2,arg3);
            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetRoundSquareTest()
        {
            // arrange
            double arg1 = 12; //radius
            var round = ShapesLib.CreateShape(arg1);
            double expected = 452.39;
            // act
            var result = ShapesLib.GetSquare(round);
            // assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void GetTrianleSquareTest()
        {
            // arrange
            double arg1 = 12; //a
            double arg2 = 15; //b
            double arg3 = 18; //c
            var triangle = ShapesLib.CreateShape(arg1, arg2, arg3);
            double expected = 89.29;
            // act
            var result = ShapesLib.GetSquare(triangle);
            // assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RectangularTest()
        {
            // arrange
            double arg1 = 5; //a
            double arg2 = 13; //b
            double arg3 = 12; //c
            var triangle = ShapesLib.CreateShape(arg1, arg2, arg3);
            bool expected = true;
            // act
            var result = triangle.IsRectangular();
            // assert
            Assert.AreEqual(expected, result);
        }






    }
}
